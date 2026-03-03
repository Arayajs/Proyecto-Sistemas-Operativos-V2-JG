using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Proyecto_Sistemas_Operativos.Entidades;

namespace Proyecto_Sistemas_Operativos.Logica
{
    internal class Cla_Utilidad
    {
        private const string RUTA_ARCHIVO_SALARIOS = @"C:\Users\josue\Downloads\SALARIOS.TXT";//Se debe asignar la ruta con respecto donde se encuentre localizado el documento

        private static Cla_Empleados[] empleados = new Cla_Empleados[40];
        private static int contador_empleados = 0;

        // Variables para manejo de hilos
        private static List<Thread> threads_activos = new List<Thread>();
        private static object lock_object = new object();

        // DataTables
        public static DataTable dt_hombres;
        public static DataTable dt_mujeres;
        public static DataTable dt_menor_1m;
        public static DataTable dt_entre_1m_3m;
        public static DataTable dt_mayor_3m;
        public static DataTable dt_principal;


        /// Carga el archivo de salarios y lo parsea a la estructura de empleados
        public static bool CargarArchivoSalarios()
        {
            return CargarArchivo(RUTA_ARCHIVO_SALARIOS);
        }

        /// Lee un archivo de texto con formato fijo y carga los datos en el arreglo de empleados
        public static bool CargarArchivo(string ruta_archivo)
        {
            try
            {
                if (!File.Exists(ruta_archivo))
                {
                    return false;
                }

                contador_empleados = 0;
                string[] lineas = File.ReadAllLines(ruta_archivo);

                foreach (string linea in lineas)
                {
                    if (contador_empleados >= 40) break;

                    if (linea.Length < 50) continue; // Asegura que la línea tenga el formato esperado (50 caracteres)

                    // Parsear campos según formato fijo
                    string cedula_str = linea.Substring(0, 9).Trim();
                    string nombre = linea.Substring(9, 30).Trim();
                    string genero_str = linea.Substring(39, 1).Trim();
                    string salario_str = linea.Substring(40, 10).Trim();

                    // Validar y convertir campos
                    if (!int.TryParse(cedula_str, out int cedula)) continue;
                    if (!int.TryParse(genero_str, out int genero)) continue;
                    if (!double.TryParse(salario_str,
                            System.Globalization.NumberStyles.Any,
                            System.Globalization.CultureInfo.InvariantCulture,
                            out double salario)) continue;

                    // Crear objeto empleado y agregarlo al arreglo
                    empleados[contador_empleados] = new Cla_Empleados
                    {
                        Cedula = cedula,
                        Nombre = nombre,
                        Genero = genero,
                        Salario_Mensual = salario,
                        Salario_Menor = false,
                        Salario_Mayor = false
                    };

                    contador_empleados++;
                }

                return contador_empleados > 0;
            }
            catch
            {
                return false;
            }
        }

        /// Crea el DataTable principal con todos los empleados y un resumen al final
        public static DataTable CrearDataGridPrincipal()
        {
            dt_principal = new DataTable();
            dt_principal.Columns.Add("Cédula", typeof(string));   // string para permitir fila de resumen
            dt_principal.Columns.Add("Nombre", typeof(string));
            dt_principal.Columns.Add("Género", typeof(string));
            dt_principal.Columns.Add("Salario Mensual", typeof(string)); // string para formatear moneda

            double salario_total = 0;

            for (int i = 0; i < contador_empleados; i++)
            {
                string genero = empleados[i].Genero == 1 ? "Masculino" : "Femenino";
                dt_principal.Rows.Add(
                    empleados[i].Cedula.ToString(),
                    empleados[i].Nombre,
                    genero,
                    empleados[i].Salario_Mensual.ToString("N2")
                );
                salario_total += empleados[i].Salario_Mensual;
            }

            // Agregar fila de resumen al final
            dt_principal.Rows.Add("", "TOTAL", $"Empleados: {contador_empleados}", salario_total.ToString("N2"));

            return dt_principal;
        }

        /// Inicia los hilos para procesar las diferentes categorías de empleados y llenar los DataTables correspondientes
        public static void IniciarThreads()
        {
            lock (lock_object)
            {
                threads_activos.Clear();
            }

            // Hilo 1: Lista de Hombres
            Thread thread_hombres = new Thread(() => ProcesarHombres());
            thread_hombres.Name = "Thread_Hombres";
            threads_activos.Add(thread_hombres);
            thread_hombres.Start();

            // Hilo 2: Lista de Mujeres
            Thread thread_mujeres = new Thread(() => ProcesarMujeres());
            thread_mujeres.Name = "Thread_Mujeres";
            threads_activos.Add(thread_mujeres);
            thread_mujeres.Start();

            // Hilo 3: Salarios < 1,000,000
            Thread thread_menor_1m = new Thread(() => ProcesarMenor1M());
            thread_menor_1m.Name = "Thread_Menor1M";
            threads_activos.Add(thread_menor_1m);
            thread_menor_1m.Start();

            // Hilo 4: Salarios entre 1,000,000 y 3,000,000
            Thread thread_entre_1m_3m = new Thread(() => ProcesarEntre1M3M());
            thread_entre_1m_3m.Name = "Thread_Entre1M3M";
            threads_activos.Add(thread_entre_1m_3m);
            thread_entre_1m_3m.Start();

            // Hilo 5: Salarios > 3,000,000
            Thread thread_mayor_3m = new Thread(() => ProcesarMayor3M());
            thread_mayor_3m.Name = "Thread_Mayor3M";
            threads_activos.Add(thread_mayor_3m);
            thread_mayor_3m.Start();
        }

        private static void ProcesarHombres()
        {
            dt_hombres = new DataTable();
            dt_hombres.Columns.Add("Cédula", typeof(string));
            dt_hombres.Columns.Add("Nombre", typeof(string));
            dt_hombres.Columns.Add("Salario Mensual", typeof(string));

            double salario_total = 0;
            int contador = 0;

            for (int i = 0; i < contador_empleados; i++)
            {
                if (empleados[i].Genero == 1)
                {
                    dt_hombres.Rows.Add(
                        empleados[i].Cedula.ToString(),
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N2")
                    );
                    salario_total += empleados[i].Salario_Mensual;
                    contador++;
                }
            }

            dt_hombres.Rows.Add("", "TOTAL", $"Empleados: {contador} | Total: {salario_total:N2}");
        }

        private static void ProcesarMujeres()
        {
            dt_mujeres = new DataTable();
            dt_mujeres.Columns.Add("Cédula", typeof(string));
            dt_mujeres.Columns.Add("Nombre", typeof(string));
            dt_mujeres.Columns.Add("Salario Mensual", typeof(string));

            double salario_total = 0;
            int contador = 0;

            for (int i = 0; i < contador_empleados; i++)
            {
                if (empleados[i].Genero == 2)
                {
                    dt_mujeres.Rows.Add(
                        empleados[i].Cedula.ToString(),
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N2")
                    );
                    salario_total += empleados[i].Salario_Mensual;
                    contador++;
                }
            }

            dt_mujeres.Rows.Add("", "TOTAL", $"Empleados: {contador} | Total: {salario_total:N2}");
        }

        private static void ProcesarMenor1M()
        {
            dt_menor_1m = new DataTable();
            dt_menor_1m.Columns.Add("Cédula", typeof(string));
            dt_menor_1m.Columns.Add("Nombre", typeof(string));
            dt_menor_1m.Columns.Add("Salario Mensual", typeof(string));

            double salario_total = 0;
            int contador = 0;

            for (int i = 0; i < contador_empleados; i++)
            {
                if (empleados[i].Salario_Mensual < 1000000)
                {
                    dt_menor_1m.Rows.Add(
                        empleados[i].Cedula.ToString(),
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N2")
                    );
                    salario_total += empleados[i].Salario_Mensual;
                    contador++;
                }
            }

            dt_menor_1m.Rows.Add("", "TOTAL", $"Empleados: {contador} | Total: {salario_total:N2}");
        }

        private static void ProcesarEntre1M3M()
        {
            dt_entre_1m_3m = new DataTable();
            dt_entre_1m_3m.Columns.Add("Cédula", typeof(string));
            dt_entre_1m_3m.Columns.Add("Nombre", typeof(string));
            dt_entre_1m_3m.Columns.Add("Salario Mensual", typeof(string));

            double salario_total = 0;
            int contador = 0;

            for (int i = 0; i < contador_empleados; i++)
            {
                if (empleados[i].Salario_Mensual >= 1000000 && empleados[i].Salario_Mensual <= 3000000)
                {
                    dt_entre_1m_3m.Rows.Add(
                        empleados[i].Cedula.ToString(),
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N2")
                    );
                    salario_total += empleados[i].Salario_Mensual;
                    contador++;
                }
            }

            dt_entre_1m_3m.Rows.Add("", "TOTAL", $"Empleados: {contador} | Total: {salario_total:N2}");
        }

        private static void ProcesarMayor3M()
        {
            dt_mayor_3m = new DataTable();
            dt_mayor_3m.Columns.Add("Cédula", typeof(string));
            dt_mayor_3m.Columns.Add("Nombre", typeof(string));
            dt_mayor_3m.Columns.Add("Salario Mensual", typeof(string));

            double salario_total = 0;
            int contador = 0;

            for (int i = 0; i < contador_empleados; i++)
            {
                if (empleados[i].Salario_Mensual > 3000000)
                {
                    dt_mayor_3m.Rows.Add(
                        empleados[i].Cedula.ToString(),
                        empleados[i].Nombre,
                        empleados[i].Salario_Mensual.ToString("N2")
                    );
                    salario_total += empleados[i].Salario_Mensual;
                    contador++;
                }
            }

            dt_mayor_3m.Rows.Add("", "TOTAL", $"Empleados: {contador} | Total: {salario_total:N2}");
        }


        /// Verifica si todos los hilos han finalizado su ejecución
        public static bool TodosThreadsFinalizados()
        {
            lock (lock_object)
            {
                return threads_activos.All(t => !t.IsAlive);
            }
        }

        /// Obtiene el empleado con el mayor salario y lo devuelve en un DataTable (non-threaded)
        public static DataTable ObtenerMayorSalario()
        {
            DataTable dt_mayor = new DataTable();
            dt_mayor.Columns.Add("Cédula", typeof(string));
            dt_mayor.Columns.Add("Nombre", typeof(string));
            dt_mayor.Columns.Add("Salario Mensual", typeof(string));

            Cla_Empleados empleado_mayor = empleados.Take(contador_empleados)
                .OrderByDescending(e => e.Salario_Mensual)
                .FirstOrDefault();

            if (empleado_mayor != null)
            {
                dt_mayor.Rows.Add(
                    empleado_mayor.Cedula.ToString(),
                    empleado_mayor.Nombre,
                    empleado_mayor.Salario_Mensual.ToString("N2")
                );
            }

            return dt_mayor;
        }

        /// Obtiene el empleado con el menor salario y lo devuelve en un DataTable (non-threaded)
        public static DataTable ObtenerMenorSalario()
        {
            DataTable dt_menor = new DataTable();
            dt_menor.Columns.Add("Cédula", typeof(string));
            dt_menor.Columns.Add("Nombre", typeof(string));
            dt_menor.Columns.Add("Salario Mensual", typeof(string));

            Cla_Empleados empleado_menor = empleados.Take(contador_empleados)
                .OrderBy(e => e.Salario_Mensual)
                .FirstOrDefault();

            if (empleado_menor != null)
            {
                dt_menor.Rows.Add(
                    empleado_menor.Cedula.ToString(),
                    empleado_menor.Nombre,
                    empleado_menor.Salario_Mensual.ToString("N2")
                );
            }

            return dt_menor;
        }

        /// Espera a que todos los hilos activos finalicen su ejecución antes de continuar
        public static void EsperarThreadsFinalizados()
        {
            foreach (Thread thread in threads_activos)
            {
                if (thread.IsAlive)
                {
                    thread.Join();
                }
            }
        }


        /// Devuelve el número total de empleados cargados en el sistema
        public static int ObtenerContadorEmpleados()
        {
            return contador_empleados;
        }
    }
}
