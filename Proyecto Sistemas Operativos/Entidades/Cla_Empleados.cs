using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Sistemas_Operativos.Entidades
{
    internal class Cla_Empleados
    {
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public int Genero { get; set; } // 1 = Hombre, 2 = Mujer
        public double Salario_Mensual { get; set; }
        public bool Salario_Menor { get; set; }
        public bool Salario_Mayor { get; set; }
    }
}
