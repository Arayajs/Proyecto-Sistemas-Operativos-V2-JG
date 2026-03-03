using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Sistemas_Operativos.Logica;

namespace Proyecto_Sistemas_Operativos.Presentacion
{
    public partial class Frm_Salarios : Form
    {
        private System.Windows.Forms.Timer timer_hilos;

        public Frm_Salarios()
        {
            InitializeComponent();
            ConfigurarDataGrids();

            timer_hilos = new System.Windows.Forms.Timer();
            timer_hilos.Interval = 200;
            timer_hilos.Tick += Timer_hilos_Tick;
        }

        private void ConfigurarDataGrids()
        {
            EstilizarGrid(dgv_principal);
            EstilizarGrid(dgv_hombres);
            EstilizarGrid(dgv_mujeres);
            EstilizarGrid(dgv_menor_1m);
            EstilizarGrid(dgv_entre_1m_3m);
            EstilizarGrid(dgv_mayor_3m);
            EstilizarGrid(dgv_mayor_salario);
            EstilizarGrid(dgv_menor_salario);
        }

        private void EstilizarGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 62, 80);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 244, 248);
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Seleccionar archivo de salarios";
                ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                ofd.InitialDirectory = @"C:\Users\josue\Downloads\SALARIOS.TXT";
                if (ofd.ShowDialog() == DialogResult.OK)
                    CargarDatos(ofd.FileName);
            }
        }

        private void btn_cargar_default_Click(object sender, EventArgs e)
        {
            CargarDatos(@"C:\Users\josue\Downloads\SALARIOS.TXT");
        }

        private void CargarDatos(string ruta)
        {
            bool cargado = Cla_Utilidad.CargarArchivo(ruta);
            if (!cargado)
            {
                MessageBox.Show($"No se pudo cargar el archivo:\n{ruta}\n\nVerifique que el archivo exista y tenga el formato correcto.",
                    "Error al cargar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int total = Cla_Utilidad.ObtenerContadorEmpleados();
            lbl_estado.Text = $"\u2714 Archivo cargado \u2014 {total} empleados encontrados";
            lbl_estado.ForeColor = Color.FromArgb(39, 174, 96);

            dgv_principal.DataSource = Cla_Utilidad.CrearDataGridPrincipal();
            dgv_mayor_salario.DataSource = Cla_Utilidad.ObtenerMayorSalario();
            dgv_menor_salario.DataSource = Cla_Utilidad.ObtenerMenorSalario();

            btn_procesar_hilos.Enabled = true;
            lbl_hilos_estado.Text = "Listo para procesar con hilos";
            lbl_hilos_estado.ForeColor = Color.FromArgb(52, 73, 94);
        }

        private void btn_procesar_hilos_Click(object sender, EventArgs e)
        {
            if (Cla_Utilidad.ObtenerContadorEmpleados() == 0)
            {
                MessageBox.Show("Primero debe cargar un archivo de salarios.", "Sin datos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgv_hombres.DataSource = null;
            dgv_mujeres.DataSource = null;
            dgv_menor_1m.DataSource = null;
            dgv_entre_1m_3m.DataSource = null;
            dgv_mayor_3m.DataSource = null;

            btn_procesar_hilos.Enabled = false;
            lbl_hilos_estado.Text = "\u23f3 Procesando con hilos...";
            lbl_hilos_estado.ForeColor = Color.FromArgb(211, 84, 0);
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.Visible = true;

            Cla_Utilidad.IniciarThreads();
            timer_hilos.Start();
        }

        private void Timer_hilos_Tick(object sender, EventArgs e)
        {
            if (Cla_Utilidad.TodosThreadsFinalizados())
            {
                timer_hilos.Stop();
                progressBar1.Visible = false;
                progressBar1.Style = ProgressBarStyle.Blocks;

                if (Cla_Utilidad.dt_hombres != null)      dgv_hombres.DataSource      = Cla_Utilidad.dt_hombres;
                if (Cla_Utilidad.dt_mujeres != null)       dgv_mujeres.DataSource      = Cla_Utilidad.dt_mujeres;
                if (Cla_Utilidad.dt_menor_1m != null)      dgv_menor_1m.DataSource     = Cla_Utilidad.dt_menor_1m;
                if (Cla_Utilidad.dt_entre_1m_3m != null)   dgv_entre_1m_3m.DataSource  = Cla_Utilidad.dt_entre_1m_3m;
                if (Cla_Utilidad.dt_mayor_3m != null)      dgv_mayor_3m.DataSource     = Cla_Utilidad.dt_mayor_3m;

                lbl_hilos_estado.Text = "\u2714 Todos los hilos finalizaron correctamente";
                lbl_hilos_estado.ForeColor = Color.FromArgb(39, 174, 96);
                btn_procesar_hilos.Enabled = true;
                tabControl1.SelectedIndex = 1;
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la aplicación?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
