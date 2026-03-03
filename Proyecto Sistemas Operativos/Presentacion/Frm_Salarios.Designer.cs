namespace Proyecto_Sistemas_Operativos.Presentacion
{
    //Formulario
    partial class Frm_Salarios
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.pnl_toolbar = new System.Windows.Forms.Panel();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_procesar_hilos = new System.Windows.Forms.Button();
            this.btn_cargar_default = new System.Windows.Forms.Button();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_principal = new System.Windows.Forms.TabPage();
            this.dgv_principal = new System.Windows.Forms.DataGridView();
            this.tabPage_categorias = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grp_hombres = new System.Windows.Forms.GroupBox();
            this.dgv_hombres = new System.Windows.Forms.DataGridView();
            this.grp_mujeres = new System.Windows.Forms.GroupBox();
            this.dgv_mujeres = new System.Windows.Forms.DataGridView();
            this.tabPage_salarios = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grp_menor_1m = new System.Windows.Forms.GroupBox();
            this.dgv_menor_1m = new System.Windows.Forms.DataGridView();
            this.grp_entre_1m_3m = new System.Windows.Forms.GroupBox();
            this.dgv_entre_1m_3m = new System.Windows.Forms.DataGridView();
            this.grp_mayor_3m = new System.Windows.Forms.GroupBox();
            this.dgv_mayor_3m = new System.Windows.Forms.DataGridView();
            this.tabPage_extremos = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grp_mayor_salario = new System.Windows.Forms.GroupBox();
            this.dgv_mayor_salario = new System.Windows.Forms.DataGridView();
            this.grp_menor_salario = new System.Windows.Forms.GroupBox();
            this.dgv_menor_salario = new System.Windows.Forms.DataGridView();
            this.pnl_footer = new System.Windows.Forms.Panel();
            this.lbl_hilos_estado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnl_header.SuspendLayout();
            this.pnl_toolbar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).BeginInit();
            this.tabPage_categorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grp_hombres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hombres)).BeginInit();
            this.grp_mujeres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mujeres)).BeginInit();
            this.tabPage_salarios.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grp_menor_1m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menor_1m)).BeginInit();
            this.grp_entre_1m_3m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entre_1m_3m)).BeginInit();
            this.grp_mayor_3m.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayor_3m)).BeginInit();
            this.tabPage_extremos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grp_mayor_salario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayor_salario)).BeginInit();
            this.grp_menor_salario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menor_salario)).BeginInit();
            this.pnl_footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnl_header.Controls.Add(this.lbl_titulo);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1100, 70);
            this.pnl_header.TabIndex = 3;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(15, 8);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(329, 30);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Sistema de Gestión de Salarios";
            // 
            // pnl_toolbar
            // 
            this.pnl_toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnl_toolbar.Controls.Add(this.lbl_estado);
            this.pnl_toolbar.Controls.Add(this.btn_salir);
            this.pnl_toolbar.Controls.Add(this.btn_procesar_hilos);
            this.pnl_toolbar.Controls.Add(this.btn_cargar_default);
            this.pnl_toolbar.Controls.Add(this.btn_cargar);
            this.pnl_toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toolbar.Location = new System.Drawing.Point(0, 70);
            this.pnl_toolbar.Name = "pnl_toolbar";
            this.pnl_toolbar.Size = new System.Drawing.Size(1100, 55);
            this.pnl_toolbar.TabIndex = 2;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.lbl_estado.Location = new System.Drawing.Point(595, 20);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(106, 15);
            this.lbl_estado.TabIndex = 0;
            this.lbl_estado.Text = "Sin datos cargados";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Location = new System.Drawing.Point(490, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 32);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "✖ Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_procesar_hilos
            // 
            this.btn_procesar_hilos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.btn_procesar_hilos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_procesar_hilos.Enabled = false;
            this.btn_procesar_hilos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.btn_procesar_hilos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_procesar_hilos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_procesar_hilos.ForeColor = System.Drawing.Color.White;
            this.btn_procesar_hilos.Location = new System.Drawing.Point(320, 12);
            this.btn_procesar_hilos.Name = "btn_procesar_hilos";
            this.btn_procesar_hilos.Size = new System.Drawing.Size(160, 32);
            this.btn_procesar_hilos.TabIndex = 2;
            this.btn_procesar_hilos.Text = "⚙ Procesar con Hilos";
            this.btn_procesar_hilos.UseVisualStyleBackColor = false;
            this.btn_procesar_hilos.Click += new System.EventHandler(this.btn_procesar_hilos_Click);
            // 
            // btn_cargar_default
            // 
            this.btn_cargar_default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_cargar_default.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cargar_default.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(100)))));
            this.btn_cargar_default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar_default.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cargar_default.ForeColor = System.Drawing.Color.White;
            this.btn_cargar_default.Location = new System.Drawing.Point(160, 12);
            this.btn_cargar_default.Name = "btn_cargar_default";
            this.btn_cargar_default.Size = new System.Drawing.Size(150, 32);
            this.btn_cargar_default.TabIndex = 3;
            this.btn_cargar_default.Text = "📄 Ruta por Defecto";
            this.btn_cargar_default.UseVisualStyleBackColor = false;
            this.btn_cargar_default.Click += new System.EventHandler(this.btn_cargar_default_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_cargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.btn_cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cargar.ForeColor = System.Drawing.Color.White;
            this.btn_cargar.Location = new System.Drawing.Point(10, 12);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(140, 32);
            this.btn_cargar.TabIndex = 4;
            this.btn_cargar.Text = "📂 Cargar Archivo";
            this.btn_cargar.UseVisualStyleBackColor = false;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_principal);
            this.tabControl1.Controls.Add(this.tabPage_categorias);
            this.tabControl1.Controls.Add(this.tabPage_salarios);
            this.tabControl1.Controls.Add(this.tabPage_extremos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.tabControl1.Location = new System.Drawing.Point(0, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 517);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_principal
            // 
            this.tabPage_principal.BackColor = System.Drawing.Color.White;
            this.tabPage_principal.Controls.Add(this.dgv_principal);
            this.tabPage_principal.Location = new System.Drawing.Point(4, 26);
            this.tabPage_principal.Name = "tabPage_principal";
            this.tabPage_principal.Padding = new System.Windows.Forms.Padding(5);
            this.tabPage_principal.Size = new System.Drawing.Size(1092, 487);
            this.tabPage_principal.TabIndex = 0;
            this.tabPage_principal.Text = "  📋 Todos los Empleados  ";
            // 
            // dgv_principal
            // 
            this.dgv_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_principal.Location = new System.Drawing.Point(5, 5);
            this.dgv_principal.Name = "dgv_principal";
            this.dgv_principal.Size = new System.Drawing.Size(1082, 477);
            this.dgv_principal.TabIndex = 0;
            // 
            // tabPage_categorias
            // 
            this.tabPage_categorias.BackColor = System.Drawing.Color.White;
            this.tabPage_categorias.Controls.Add(this.splitContainer1);
            this.tabPage_categorias.Location = new System.Drawing.Point(4, 26);
            this.tabPage_categorias.Name = "tabPage_categorias";
            this.tabPage_categorias.Size = new System.Drawing.Size(192, 70);
            this.tabPage_categorias.TabIndex = 1;
            this.tabPage_categorias.Text = "  👥 Por Género  ";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grp_hombres);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grp_mujeres);
            this.splitContainer1.Size = new System.Drawing.Size(192, 70);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // grp_hombres
            // 
            this.grp_hombres.Controls.Add(this.dgv_hombres);
            this.grp_hombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_hombres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grp_hombres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grp_hombres.Location = new System.Drawing.Point(0, 0);
            this.grp_hombres.Name = "grp_hombres";
            this.grp_hombres.Size = new System.Drawing.Size(192, 41);
            this.grp_hombres.TabIndex = 0;
            this.grp_hombres.TabStop = false;
            this.grp_hombres.Text = "  👨 Empleados Masculinos";
            // 
            // dgv_hombres
            // 
            this.dgv_hombres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hombres.Location = new System.Drawing.Point(3, 20);
            this.dgv_hombres.Name = "dgv_hombres";
            this.dgv_hombres.Size = new System.Drawing.Size(186, 18);
            this.dgv_hombres.TabIndex = 0;
            // 
            // grp_mujeres
            // 
            this.grp_mujeres.Controls.Add(this.dgv_mujeres);
            this.grp_mujeres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_mujeres.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grp_mujeres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.grp_mujeres.Location = new System.Drawing.Point(0, 0);
            this.grp_mujeres.Name = "grp_mujeres";
            this.grp_mujeres.Size = new System.Drawing.Size(192, 25);
            this.grp_mujeres.TabIndex = 0;
            this.grp_mujeres.TabStop = false;
            this.grp_mujeres.Text = "  👩 Empleados Femeninos";
            // 
            // dgv_mujeres
            // 
            this.dgv_mujeres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mujeres.Location = new System.Drawing.Point(3, 20);
            this.dgv_mujeres.Name = "dgv_mujeres";
            this.dgv_mujeres.Size = new System.Drawing.Size(186, 2);
            this.dgv_mujeres.TabIndex = 0;
            // 
            // tabPage_salarios
            // 
            this.tabPage_salarios.BackColor = System.Drawing.Color.White;
            this.tabPage_salarios.Controls.Add(this.tableLayoutPanel1);
            this.tabPage_salarios.Location = new System.Drawing.Point(4, 26);
            this.tabPage_salarios.Name = "tabPage_salarios";
            this.tabPage_salarios.Size = new System.Drawing.Size(192, 70);
            this.tabPage_salarios.TabIndex = 2;
            this.tabPage_salarios.Text = "  💰 Por Rango Salarial  ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.tableLayoutPanel1.Controls.Add(this.grp_menor_1m, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grp_entre_1m_3m, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.grp_mayor_3m, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // grp_menor_1m
            // 
            this.grp_menor_1m.Controls.Add(this.dgv_menor_1m);
            this.grp_menor_1m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_menor_1m.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grp_menor_1m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.grp_menor_1m.Location = new System.Drawing.Point(3, 3);
            this.grp_menor_1m.Name = "grp_menor_1m";
            this.grp_menor_1m.Size = new System.Drawing.Size(57, 64);
            this.grp_menor_1m.TabIndex = 0;
            this.grp_menor_1m.TabStop = false;
            this.grp_menor_1m.Text = "  < ₡1,000,000";
            // 
            // dgv_menor_1m
            // 
            this.dgv_menor_1m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_menor_1m.Location = new System.Drawing.Point(3, 20);
            this.dgv_menor_1m.Name = "dgv_menor_1m";
            this.dgv_menor_1m.Size = new System.Drawing.Size(51, 41);
            this.dgv_menor_1m.TabIndex = 0;
            // 
            // grp_entre_1m_3m
            // 
            this.grp_entre_1m_3m.Controls.Add(this.dgv_entre_1m_3m);
            this.grp_entre_1m_3m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_entre_1m_3m.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grp_entre_1m_3m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.grp_entre_1m_3m.Location = new System.Drawing.Point(66, 3);
            this.grp_entre_1m_3m.Name = "grp_entre_1m_3m";
            this.grp_entre_1m_3m.Size = new System.Drawing.Size(57, 64);
            this.grp_entre_1m_3m.TabIndex = 1;
            this.grp_entre_1m_3m.TabStop = false;
            this.grp_entre_1m_3m.Text = "  ₡1,000,000 — ₡3,000,000";
            // 
            // dgv_entre_1m_3m
            // 
            this.dgv_entre_1m_3m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_entre_1m_3m.Location = new System.Drawing.Point(3, 20);
            this.dgv_entre_1m_3m.Name = "dgv_entre_1m_3m";
            this.dgv_entre_1m_3m.Size = new System.Drawing.Size(51, 41);
            this.dgv_entre_1m_3m.TabIndex = 0;
            // 
            // grp_mayor_3m
            // 
            this.grp_mayor_3m.Controls.Add(this.dgv_mayor_3m);
            this.grp_mayor_3m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_mayor_3m.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grp_mayor_3m.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.grp_mayor_3m.Location = new System.Drawing.Point(129, 3);
            this.grp_mayor_3m.Name = "grp_mayor_3m";
            this.grp_mayor_3m.Size = new System.Drawing.Size(60, 64);
            this.grp_mayor_3m.TabIndex = 2;
            this.grp_mayor_3m.TabStop = false;
            this.grp_mayor_3m.Text = "  > ₡3,000,000";
            // 
            // dgv_mayor_3m
            // 
            this.dgv_mayor_3m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mayor_3m.Location = new System.Drawing.Point(3, 20);
            this.dgv_mayor_3m.Name = "dgv_mayor_3m";
            this.dgv_mayor_3m.Size = new System.Drawing.Size(54, 41);
            this.dgv_mayor_3m.TabIndex = 0;
            // 
            // tabPage_extremos
            // 
            this.tabPage_extremos.BackColor = System.Drawing.Color.White;
            this.tabPage_extremos.Controls.Add(this.splitContainer2);
            this.tabPage_extremos.Location = new System.Drawing.Point(4, 26);
            this.tabPage_extremos.Name = "tabPage_extremos";
            this.tabPage_extremos.Size = new System.Drawing.Size(192, 70);
            this.tabPage_extremos.TabIndex = 3;
            this.tabPage_extremos.Text = "  🏆 Mayor y Menor Salario  ";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.grp_mayor_salario);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grp_menor_salario);
            this.splitContainer2.Size = new System.Drawing.Size(192, 70);
            this.splitContainer2.SplitterDistance = 41;
            this.splitContainer2.TabIndex = 0;
            // 
            // grp_mayor_salario
            // 
            this.grp_mayor_salario.Controls.Add(this.dgv_mayor_salario);
            this.grp_mayor_salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_mayor_salario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grp_mayor_salario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.grp_mayor_salario.Location = new System.Drawing.Point(0, 0);
            this.grp_mayor_salario.Name = "grp_mayor_salario";
            this.grp_mayor_salario.Size = new System.Drawing.Size(192, 41);
            this.grp_mayor_salario.TabIndex = 0;
            this.grp_mayor_salario.TabStop = false;
            this.grp_mayor_salario.Text = "  🥇 Empleado con Mayor Salario";
            // 
            // dgv_mayor_salario
            // 
            this.dgv_mayor_salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_mayor_salario.Location = new System.Drawing.Point(3, 21);
            this.dgv_mayor_salario.Name = "dgv_mayor_salario";
            this.dgv_mayor_salario.Size = new System.Drawing.Size(186, 17);
            this.dgv_mayor_salario.TabIndex = 0;
            // 
            // grp_menor_salario
            // 
            this.grp_menor_salario.Controls.Add(this.dgv_menor_salario);
            this.grp_menor_salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_menor_salario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grp_menor_salario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.grp_menor_salario.Location = new System.Drawing.Point(0, 0);
            this.grp_menor_salario.Name = "grp_menor_salario";
            this.grp_menor_salario.Size = new System.Drawing.Size(192, 25);
            this.grp_menor_salario.TabIndex = 0;
            this.grp_menor_salario.TabStop = false;
            this.grp_menor_salario.Text = "  🥉 Empleado con Menor Salario";
            // 
            // dgv_menor_salario
            // 
            this.dgv_menor_salario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_menor_salario.Location = new System.Drawing.Point(3, 21);
            this.dgv_menor_salario.Name = "dgv_menor_salario";
            this.dgv_menor_salario.Size = new System.Drawing.Size(186, 1);
            this.dgv_menor_salario.TabIndex = 0;
            // 
            // pnl_footer
            // 
            this.pnl_footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnl_footer.Controls.Add(this.lbl_hilos_estado);
            this.pnl_footer.Controls.Add(this.progressBar1);
            this.pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_footer.Location = new System.Drawing.Point(0, 642);
            this.pnl_footer.Name = "pnl_footer";
            this.pnl_footer.Size = new System.Drawing.Size(1100, 38);
            this.pnl_footer.TabIndex = 1;
            // 
            // lbl_hilos_estado
            // 
            this.lbl_hilos_estado.AutoSize = true;
            this.lbl_hilos_estado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_hilos_estado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbl_hilos_estado.Location = new System.Drawing.Point(10, 10);
            this.lbl_hilos_estado.Name = "lbl_hilos_estado";
            this.lbl_hilos_estado.Size = new System.Drawing.Size(103, 15);
            this.lbl_hilos_estado.TabIndex = 0;
            this.lbl_hilos_estado.Text = "Esperando datos...";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(1600, 8);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 22);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // Frm_Salarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnl_footer);
            this.Controls.Add(this.pnl_toolbar);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Frm_Salarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Salarios — Sistemas Operativos";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_toolbar.ResumeLayout(false);
            this.pnl_toolbar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_principal)).EndInit();
            this.tabPage_categorias.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grp_hombres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hombres)).EndInit();
            this.grp_mujeres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mujeres)).EndInit();
            this.tabPage_salarios.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grp_menor_1m.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menor_1m)).EndInit();
            this.grp_entre_1m_3m.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entre_1m_3m)).EndInit();
            this.grp_mayor_3m.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayor_3m)).EndInit();
            this.tabPage_extremos.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grp_mayor_salario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mayor_salario)).EndInit();
            this.grp_menor_salario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menor_salario)).EndInit();
            this.pnl_footer.ResumeLayout(false);
            this.pnl_footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // ── Control declarations ──
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Panel pnl_toolbar;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.Button btn_cargar_default;
        private System.Windows.Forms.Button btn_procesar_hilos;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_principal;
        private System.Windows.Forms.DataGridView dgv_principal;
        private System.Windows.Forms.TabPage tabPage_categorias;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grp_hombres;
        private System.Windows.Forms.DataGridView dgv_hombres;
        private System.Windows.Forms.GroupBox grp_mujeres;
        private System.Windows.Forms.DataGridView dgv_mujeres;
        private System.Windows.Forms.TabPage tabPage_salarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grp_menor_1m;
        private System.Windows.Forms.DataGridView dgv_menor_1m;
        private System.Windows.Forms.GroupBox grp_entre_1m_3m;
        private System.Windows.Forms.DataGridView dgv_entre_1m_3m;
        private System.Windows.Forms.GroupBox grp_mayor_3m;
        private System.Windows.Forms.DataGridView dgv_mayor_3m;
        private System.Windows.Forms.TabPage tabPage_extremos;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox grp_mayor_salario;
        private System.Windows.Forms.DataGridView dgv_mayor_salario;
        private System.Windows.Forms.GroupBox grp_menor_salario;
        private System.Windows.Forms.DataGridView dgv_menor_salario;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_hilos_estado;
    }
}
