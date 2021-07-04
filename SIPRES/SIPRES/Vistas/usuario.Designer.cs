namespace SIPRES.Vistas
{
    partial class usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TC_usuario = new System.Windows.Forms.TabControl();
            this.TP_listar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_pdf = new System.Windows.Forms.Button();
            this.BT_nuevo_mini = new System.Windows.Forms.Button();
            this.BT_editar_mini = new System.Windows.Forms.Button();
            this.BT_excel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.DGV_datos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TX_buscar = new System.Windows.Forms.TextBox();
            this.TP_administrar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_apellido = new System.Windows.Forms.MaskedTextBox();
            this.TX_nombre = new System.Windows.Forms.MaskedTextBox();
            this.TX_identidad = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TX_edad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_sexo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DT_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_indicador = new System.Windows.Forms.Label();
            this.CB_activo = new System.Windows.Forms.CheckBox();
            this.CB_rol = new System.Windows.Forms.ComboBox();
            this.TX_id_usu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TX_contra = new System.Windows.Forms.MaskedTextBox();
            this.TX_confir = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.BT_editar = new System.Windows.Forms.Button();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.BT_nuevo = new System.Windows.Forms.Button();
            this.SFD_excel = new System.Windows.Forms.SaveFileDialog();
            this.SFD_pdf = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BT_salir = new System.Windows.Forms.Button();
            this.TC_usuario.SuspendLayout();
            this.TP_listar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datos)).BeginInit();
            this.TP_administrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TC_usuario
            // 
            this.TC_usuario.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TC_usuario.Controls.Add(this.TP_listar);
            this.TC_usuario.Controls.Add(this.TP_administrar);
            this.TC_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_usuario.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.TC_usuario.Location = new System.Drawing.Point(60, 0);
            this.TC_usuario.Margin = new System.Windows.Forms.Padding(6);
            this.TC_usuario.Name = "TC_usuario";
            this.TC_usuario.SelectedIndex = 0;
            this.TC_usuario.Size = new System.Drawing.Size(1032, 515);
            this.TC_usuario.TabIndex = 32;
            this.TC_usuario.Selected += new System.Windows.Forms.TabControlEventHandler(this.TC_usuario_Selected);
            // 
            // TP_listar
            // 
            this.TP_listar.Controls.Add(this.panel2);
            this.TP_listar.Controls.Add(this.groupBox3);
            this.TP_listar.Location = new System.Drawing.Point(4, 37);
            this.TP_listar.Name = "TP_listar";
            this.TP_listar.Padding = new System.Windows.Forms.Padding(3);
            this.TP_listar.Size = new System.Drawing.Size(1024, 474);
            this.TP_listar.TabIndex = 1;
            this.TP_listar.Text = "Listar";
            this.TP_listar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.BT_pdf);
            this.panel2.Controls.Add(this.BT_nuevo_mini);
            this.panel2.Controls.Add(this.BT_editar_mini);
            this.panel2.Controls.Add(this.BT_excel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(929, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 468);
            this.panel2.TabIndex = 31;
            // 
            // BT_pdf
            // 
            this.BT_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_pdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_pdf.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_pdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_pdf.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_pdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_pdf.Image = global::SIPRES.Properties.Resources.pdf;
            this.BT_pdf.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_pdf.Location = new System.Drawing.Point(2, 398);
            this.BT_pdf.Name = "BT_pdf";
            this.BT_pdf.Size = new System.Drawing.Size(89, 38);
            this.BT_pdf.TabIndex = 4;
            this.BT_pdf.Text = "PDF";
            this.BT_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_pdf.UseVisualStyleBackColor = false;
            this.BT_pdf.Click += new System.EventHandler(this.BT_pdf_Click);
            // 
            // BT_nuevo_mini
            // 
            this.BT_nuevo_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_nuevo_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_nuevo_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_nuevo_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_nuevo_mini.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_nuevo_mini.FlatAppearance.BorderSize = 0;
            this.BT_nuevo_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_nuevo_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_nuevo_mini.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_nuevo_mini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_nuevo_mini.Image = global::SIPRES.Properties.Resources.Nuevo24;
            this.BT_nuevo_mini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_nuevo_mini.Location = new System.Drawing.Point(0, 18);
            this.BT_nuevo_mini.Name = "BT_nuevo_mini";
            this.BT_nuevo_mini.Size = new System.Drawing.Size(91, 35);
            this.BT_nuevo_mini.TabIndex = 2;
            this.BT_nuevo_mini.Text = "Nuevo";
            this.BT_nuevo_mini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_nuevo_mini.UseVisualStyleBackColor = false;
            this.BT_nuevo_mini.Click += new System.EventHandler(this.BT_nuevo_mini_Click);
            // 
            // BT_editar_mini
            // 
            this.BT_editar_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_editar_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_editar_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_editar_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_editar_mini.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_editar_mini.FlatAppearance.BorderSize = 0;
            this.BT_editar_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_editar_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_editar_mini.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_editar_mini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_editar_mini.Image = global::SIPRES.Properties.Resources.Editar24;
            this.BT_editar_mini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_editar_mini.Location = new System.Drawing.Point(3, 62);
            this.BT_editar_mini.Name = "BT_editar_mini";
            this.BT_editar_mini.Size = new System.Drawing.Size(89, 38);
            this.BT_editar_mini.TabIndex = 3;
            this.BT_editar_mini.Text = "Editar";
            this.BT_editar_mini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_editar_mini.UseVisualStyleBackColor = false;
            this.BT_editar_mini.Click += new System.EventHandler(this.BT_editar_mini_Click);
            // 
            // BT_excel
            // 
            this.BT_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_excel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_excel.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_excel.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_excel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_excel.Image = global::SIPRES.Properties.Resources.xls;
            this.BT_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_excel.Location = new System.Drawing.Point(2, 355);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(89, 38);
            this.BT_excel.TabIndex = 5;
            this.BT_excel.Text = "Excel";
            this.BT_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_excel.UseVisualStyleBackColor = false;
            this.BT_excel.Click += new System.EventHandler(this.BT_excel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.BT_limpiar);
            this.groupBox3.Controls.Add(this.DGV_datos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TX_buscar);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1018, 468);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar Usuario";
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.Image = global::SIPRES.Properties.Resources.limpiar24;
            this.BT_limpiar.Location = new System.Drawing.Point(423, 24);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(28, 29);
            this.BT_limpiar.TabIndex = 1;
            this.BT_limpiar.UseVisualStyleBackColor = true;
            this.BT_limpiar.Click += new System.EventHandler(this.BT_limpiar_Click);
            // 
            // DGV_datos
            // 
            this.DGV_datos.AllowUserToAddRows = false;
            this.DGV_datos.AllowUserToDeleteRows = false;
            this.DGV_datos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_datos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGV_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_datos.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_datos.EnableHeadersVisualStyles = false;
            this.DGV_datos.Location = new System.Drawing.Point(9, 62);
            this.DGV_datos.Name = "DGV_datos";
            this.DGV_datos.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_datos.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_datos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_datos.Size = new System.Drawing.Size(904, 374);
            this.DGV_datos.TabIndex = 12;
            this.DGV_datos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_datos_CellContentDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Busqueda";
            // 
            // TX_buscar
            // 
            this.TX_buscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_buscar.Location = new System.Drawing.Point(130, 25);
            this.TX_buscar.Name = "TX_buscar";
            this.TX_buscar.Size = new System.Drawing.Size(278, 29);
            this.TX_buscar.TabIndex = 0;
            this.TX_buscar.TextChanged += new System.EventHandler(this.TX_buscar_TextChanged);
            // 
            // TP_administrar
            // 
            this.TP_administrar.Controls.Add(this.groupBox1);
            this.TP_administrar.Controls.Add(this.groupBox2);
            this.TP_administrar.Controls.Add(this.panel1);
            this.TP_administrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_administrar.Location = new System.Drawing.Point(4, 37);
            this.TP_administrar.Name = "TP_administrar";
            this.TP_administrar.Padding = new System.Windows.Forms.Padding(3);
            this.TP_administrar.Size = new System.Drawing.Size(1024, 474);
            this.TP_administrar.TabIndex = 0;
            this.TP_administrar.Text = "Administrar";
            this.TP_administrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TX_apellido);
            this.groupBox1.Controls.Add(this.TX_nombre);
            this.groupBox1.Controls.Add(this.TX_identidad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TX_edad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CB_sexo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DT_nacimiento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 242);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del  Personales";
            // 
            // TX_apellido
            // 
            this.TX_apellido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_apellido.Location = new System.Drawing.Point(187, 109);
            this.TX_apellido.Mask = ">?????????????????????????????";
            this.TX_apellido.Name = "TX_apellido";
            this.TX_apellido.ReadOnly = true;
            this.TX_apellido.Size = new System.Drawing.Size(235, 27);
            this.TX_apellido.TabIndex = 10;
            // 
            // TX_nombre
            // 
            this.TX_nombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_nombre.Location = new System.Drawing.Point(619, 53);
            this.TX_nombre.Mask = ">?????????????????????????????";
            this.TX_nombre.Name = "TX_nombre";
            this.TX_nombre.ReadOnly = true;
            this.TX_nombre.Size = new System.Drawing.Size(239, 27);
            this.TX_nombre.TabIndex = 9;
            // 
            // TX_identidad
            // 
            this.TX_identidad.BackColor = System.Drawing.SystemColors.Info;
            this.TX_identidad.Enabled = false;
            this.TX_identidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_identidad.Location = new System.Drawing.Point(187, 53);
            this.TX_identidad.Mask = "0000-0000-00000";
            this.TX_identidad.Name = "TX_identidad";
            this.TX_identidad.Size = new System.Drawing.Size(235, 27);
            this.TX_identidad.TabIndex = 8;
            this.TX_identidad.DoubleClick += new System.EventHandler(this.TX_identidad_DoubleClick);
            this.TX_identidad.Leave += new System.EventHandler(this.TX_identidad_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Edad";
            // 
            // TX_edad
            // 
            this.TX_edad.Enabled = false;
            this.TX_edad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_edad.Location = new System.Drawing.Point(619, 172);
            this.TX_edad.Name = "TX_edad";
            this.TX_edad.ReadOnly = true;
            this.TX_edad.Size = new System.Drawing.Size(239, 27);
            this.TX_edad.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "# Identidad";
            // 
            // CB_sexo
            // 
            this.CB_sexo.Enabled = false;
            this.CB_sexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_sexo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_sexo.FormattingEnabled = true;
            this.CB_sexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CB_sexo.Location = new System.Drawing.Point(187, 171);
            this.CB_sexo.Name = "CB_sexo";
            this.CB_sexo.Size = new System.Drawing.Size(235, 28);
            this.CB_sexo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sexo";
            // 
            // DT_nacimiento
            // 
            this.DT_nacimiento.Enabled = false;
            this.DT_nacimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_nacimiento.Location = new System.Drawing.Point(619, 107);
            this.DT_nacimiento.Name = "DT_nacimiento";
            this.DT_nacimiento.Size = new System.Drawing.Size(239, 27);
            this.DT_nacimiento.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.LB_indicador);
            this.groupBox2.Controls.Add(this.CB_activo);
            this.groupBox2.Controls.Add(this.CB_rol);
            this.groupBox2.Controls.Add(this.TX_id_usu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TX_contra);
            this.groupBox2.Controls.Add(this.TX_confir);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(875, 181);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datis de Ingrero";
            // 
            // LB_indicador
            // 
            this.LB_indicador.AutoSize = true;
            this.LB_indicador.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_indicador.Location = new System.Drawing.Point(658, 153);
            this.LB_indicador.Name = "LB_indicador";
            this.LB_indicador.Size = new System.Drawing.Size(0, 20);
            this.LB_indicador.TabIndex = 28;
            // 
            // CB_activo
            // 
            this.CB_activo.AutoSize = true;
            this.CB_activo.Enabled = false;
            this.CB_activo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_activo.Location = new System.Drawing.Point(792, 19);
            this.CB_activo.Name = "CB_activo";
            this.CB_activo.Size = new System.Drawing.Size(66, 21);
            this.CB_activo.TabIndex = 27;
            this.CB_activo.Text = "Activo";
            this.CB_activo.UseVisualStyleBackColor = true;
            // 
            // CB_rol
            // 
            this.CB_rol.Enabled = false;
            this.CB_rol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_rol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_rol.FormattingEnabled = true;
            this.CB_rol.Location = new System.Drawing.Point(187, 114);
            this.CB_rol.Name = "CB_rol";
            this.CB_rol.Size = new System.Drawing.Size(235, 28);
            this.CB_rol.TabIndex = 26;
            // 
            // TX_id_usu
            // 
            this.TX_id_usu.Enabled = false;
            this.TX_id_usu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_id_usu.Location = new System.Drawing.Point(187, 62);
            this.TX_id_usu.Name = "TX_id_usu";
            this.TX_id_usu.ReadOnly = true;
            this.TX_id_usu.Size = new System.Drawing.Size(235, 27);
            this.TX_id_usu.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(483, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Confirmar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Rol";
            // 
            // TX_contra
            // 
            this.TX_contra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_contra.Location = new System.Drawing.Point(619, 62);
            this.TX_contra.Name = "TX_contra";
            this.TX_contra.PasswordChar = '☠';
            this.TX_contra.ReadOnly = true;
            this.TX_contra.Size = new System.Drawing.Size(239, 27);
            this.TX_contra.TabIndex = 14;
            // 
            // TX_confir
            // 
            this.TX_confir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_confir.Location = new System.Drawing.Point(619, 114);
            this.TX_confir.Name = "TX_confir";
            this.TX_confir.PasswordChar = '☠';
            this.TX_confir.ReadOnly = true;
            this.TX_confir.Size = new System.Drawing.Size(239, 27);
            this.TX_confir.TabIndex = 13;
            this.TX_confir.Leave += new System.EventHandler(this.TX_confir_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(481, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.BT_cancelar);
            this.panel1.Controls.Add(this.BT_editar);
            this.panel1.Controls.Add(this.BT_guardar);
            this.panel1.Controls.Add(this.BT_nuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(909, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 468);
            this.panel1.TabIndex = 34;
            // 
            // BT_cancelar
            // 
            this.BT_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_cancelar.FlatAppearance.BorderSize = 0;
            this.BT_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_cancelar.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_cancelar.Image = global::SIPRES.Properties.Resources.Cacelar24;
            this.BT_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_cancelar.Location = new System.Drawing.Point(1, 408);
            this.BT_cancelar.Name = "BT_cancelar";
            this.BT_cancelar.Size = new System.Drawing.Size(112, 38);
            this.BT_cancelar.TabIndex = 17;
            this.BT_cancelar.Text = "Calcelar";
            this.BT_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_cancelar.UseVisualStyleBackColor = false;
            this.BT_cancelar.Visible = false;
            this.BT_cancelar.Click += new System.EventHandler(this.BT_cancelar_Click);
            // 
            // BT_editar
            // 
            this.BT_editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_editar.Enabled = false;
            this.BT_editar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_editar.FlatAppearance.BorderSize = 0;
            this.BT_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_editar.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_editar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_editar.Image = global::SIPRES.Properties.Resources.Editar24;
            this.BT_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_editar.Location = new System.Drawing.Point(3, 326);
            this.BT_editar.Name = "BT_editar";
            this.BT_editar.Size = new System.Drawing.Size(109, 38);
            this.BT_editar.TabIndex = 18;
            this.BT_editar.Text = "Editar   ";
            this.BT_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_editar.UseVisualStyleBackColor = false;
            this.BT_editar.Click += new System.EventHandler(this.BT_editar_Click);
            // 
            // BT_guardar
            // 
            this.BT_guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_guardar.Enabled = false;
            this.BT_guardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_guardar.FlatAppearance.BorderSize = 0;
            this.BT_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_guardar.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_guardar.Image = global::SIPRES.Properties.Resources.Aplicar224;
            this.BT_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_guardar.Location = new System.Drawing.Point(3, 367);
            this.BT_guardar.Name = "BT_guardar";
            this.BT_guardar.Size = new System.Drawing.Size(109, 38);
            this.BT_guardar.TabIndex = 16;
            this.BT_guardar.Text = "Guardar";
            this.BT_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_guardar.UseVisualStyleBackColor = false;
            this.BT_guardar.Click += new System.EventHandler(this.BT_guardar_Click);
            // 
            // BT_nuevo
            // 
            this.BT_nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_nuevo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_nuevo.FlatAppearance.BorderSize = 0;
            this.BT_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_nuevo.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_nuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_nuevo.Image = global::SIPRES.Properties.Resources.Nuevo24;
            this.BT_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_nuevo.Location = new System.Drawing.Point(4, 285);
            this.BT_nuevo.Name = "BT_nuevo";
            this.BT_nuevo.Size = new System.Drawing.Size(107, 38);
            this.BT_nuevo.TabIndex = 7;
            this.BT_nuevo.Text = "Nuevo  ";
            this.BT_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_nuevo.UseVisualStyleBackColor = false;
            this.BT_nuevo.Click += new System.EventHandler(this.BT_nuevo_Click);
            // 
            // SFD_excel
            // 
            this.SFD_excel.Filter = "\"Archivo CSV|*.csv\"";
            this.SFD_excel.InitialDirectory = "C:\\Sipres\\Reportes\\Excel";
            // 
            // SFD_pdf
            // 
            this.SFD_pdf.FileName = ".pdf";
            this.SFD_pdf.Filter = "\"Archivo PDF|*.pdf\"";
            this.SFD_pdf.InitialDirectory = "C:\\Sipres\\Reportes\\PDF";
            this.SFD_pdf.Title = "Exportar a PDF";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SIPRES.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // BT_salir
            // 
            this.BT_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_salir.FlatAppearance.BorderSize = 0;
            this.BT_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_salir.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_salir.Location = new System.Drawing.Point(11, 12);
            this.BT_salir.Name = "BT_salir";
            this.BT_salir.Size = new System.Drawing.Size(40, 44);
            this.BT_salir.TabIndex = 33;
            this.BT_salir.Text = "X";
            this.BT_salir.UseVisualStyleBackColor = false;
            this.BT_salir.Click += new System.EventHandler(this.BT_salir_Click);
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 515);
            this.Controls.Add(this.BT_salir);
            this.Controls.Add(this.TC_usuario);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.TC_usuario.ResumeLayout(false);
            this.TP_listar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datos)).EndInit();
            this.TP_administrar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl TC_usuario;
        private System.Windows.Forms.TabPage TP_listar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BT_pdf;
        private System.Windows.Forms.Button BT_nuevo_mini;
        private System.Windows.Forms.Button BT_editar_mini;
        private System.Windows.Forms.Button BT_excel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BT_limpiar;
        private System.Windows.Forms.DataGridView DGV_datos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TX_buscar;
        private System.Windows.Forms.TabPage TP_administrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TX_apellido;
        private System.Windows.Forms.MaskedTextBox TX_nombre;
        private System.Windows.Forms.MaskedTextBox TX_identidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TX_edad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DT_nacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB_indicador;
        private System.Windows.Forms.CheckBox CB_activo;
        private System.Windows.Forms.ComboBox CB_rol;
        private System.Windows.Forms.TextBox TX_id_usu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TX_contra;
        private System.Windows.Forms.MaskedTextBox TX_confir;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Button BT_editar;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Button BT_nuevo;
        private System.Windows.Forms.SaveFileDialog SFD_excel;
        private System.Windows.Forms.SaveFileDialog SFD_pdf;
        private System.Windows.Forms.Button BT_salir;
    }
}