namespace SIPRES.Vistas
{
    partial class proyecto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TC_proyecto = new System.Windows.Forms.TabControl();
            this.TP_listar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BT_imprimir = new System.Windows.Forms.Button();
            this.BT_ver = new System.Windows.Forms.Button();
            this.BT_pdf = new System.Windows.Forms.Button();
            this.BT_nuevo_mini = new System.Windows.Forms.Button();
            this.BT_editar_mini = new System.Windows.Forms.Button();
            this.BT_excel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RB_emp_b = new System.Windows.Forms.RadioButton();
            this.RB_per_b = new System.Windows.Forms.RadioButton();
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.DGV_datos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TX_buscar = new System.Windows.Forms.TextBox();
            this.TP_administrar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_fin = new System.Windows.Forms.DateTimePicker();
            this.DT_inicio = new System.Windows.Forms.DateTimePicker();
            this.TX_identidad = new System.Windows.Forms.MaskedTextBox();
            this.TX_nombre_p = new System.Windows.Forms.MaskedTextBox();
            this.RB_emp = new System.Windows.Forms.RadioButton();
            this.RB_per = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_descripion = new System.Windows.Forms.TextBox();
            this.TX_nombre = new System.Windows.Forms.MaskedTextBox();
            this.TX_estado = new System.Windows.Forms.MaskedTextBox();
            this.TX_id_proy = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TX_linea = new System.Windows.Forms.TextBox();
            this.DGV_detalle = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_eliminar_d = new System.Windows.Forms.Button();
            this.BT_nuevo_d = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.BT_editar = new System.Windows.Forms.Button();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.BT_nuevo = new System.Windows.Forms.Button();
            this.BT_salir = new System.Windows.Forms.Button();
            this.SFD_pdf = new System.Windows.Forms.SaveFileDialog();
            this.SFD_excel = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TC_proyecto.SuspendLayout();
            this.TP_listar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_datos)).BeginInit();
            this.TP_administrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detalle)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TC_proyecto
            // 
            this.TC_proyecto.Controls.Add(this.TP_listar);
            this.TC_proyecto.Controls.Add(this.TP_administrar);
            this.TC_proyecto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_proyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_proyecto.Location = new System.Drawing.Point(60, 0);
            this.TC_proyecto.Margin = new System.Windows.Forms.Padding(6);
            this.TC_proyecto.Name = "TC_proyecto";
            this.TC_proyecto.SelectedIndex = 0;
            this.TC_proyecto.Size = new System.Drawing.Size(1016, 476);
            this.TC_proyecto.TabIndex = 36;
            this.TC_proyecto.Selected += new System.Windows.Forms.TabControlEventHandler(this.TC_proyecto_Selected);
            // 
            // TP_listar
            // 
            this.TP_listar.BackColor = System.Drawing.Color.Transparent;
            this.TP_listar.Controls.Add(this.panel2);
            this.TP_listar.Controls.Add(this.groupBox3);
            this.TP_listar.Font = new System.Drawing.Font("Abecedary", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_listar.Location = new System.Drawing.Point(4, 30);
            this.TP_listar.Name = "TP_listar";
            this.TP_listar.Padding = new System.Windows.Forms.Padding(3);
            this.TP_listar.Size = new System.Drawing.Size(1008, 442);
            this.TP_listar.TabIndex = 1;
            this.TP_listar.Text = "Listar";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.BT_imprimir);
            this.panel2.Controls.Add(this.BT_ver);
            this.panel2.Controls.Add(this.BT_pdf);
            this.panel2.Controls.Add(this.BT_nuevo_mini);
            this.panel2.Controls.Add(this.BT_editar_mini);
            this.panel2.Controls.Add(this.BT_excel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(908, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 436);
            this.panel2.TabIndex = 31;
            // 
            // BT_imprimir
            // 
            this.BT_imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_imprimir.FlatAppearance.BorderSize = 0;
            this.BT_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_imprimir.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_imprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_imprimir.Image = global::SIPRES.Properties.Resources.imprimir24;
            this.BT_imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_imprimir.Location = new System.Drawing.Point(0, 150);
            this.BT_imprimir.Name = "BT_imprimir";
            this.BT_imprimir.Size = new System.Drawing.Size(96, 38);
            this.BT_imprimir.TabIndex = 7;
            this.BT_imprimir.Text = "Imp.";
            this.BT_imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_imprimir.UseVisualStyleBackColor = false;
            this.BT_imprimir.Click += new System.EventHandler(this.BT_imprimir_Click);
            // 
            // BT_ver
            // 
            this.BT_ver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BT_ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ver.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_ver.FlatAppearance.BorderSize = 0;
            this.BT_ver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ver.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_ver.Image = global::SIPRES.Properties.Resources.ver1;
            this.BT_ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_ver.Location = new System.Drawing.Point(0, 106);
            this.BT_ver.Name = "BT_ver";
            this.BT_ver.Size = new System.Drawing.Size(99, 38);
            this.BT_ver.TabIndex = 6;
            this.BT_ver.Text = "   Ver   ";
            this.BT_ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_ver.UseVisualStyleBackColor = false;
            this.BT_ver.Click += new System.EventHandler(this.BT_ver_Click);
            // 
            // BT_pdf
            // 
            this.BT_pdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.BT_pdf.Location = new System.Drawing.Point(0, 360);
            this.BT_pdf.Name = "BT_pdf";
            this.BT_pdf.Size = new System.Drawing.Size(98, 38);
            this.BT_pdf.TabIndex = 4;
            this.BT_pdf.Text = "PDF";
            this.BT_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_pdf.UseVisualStyleBackColor = false;
            this.BT_pdf.Click += new System.EventHandler(this.BT_pdf_Click);
            // 
            // BT_nuevo_mini
            // 
            this.BT_nuevo_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.BT_nuevo_mini.Size = new System.Drawing.Size(96, 38);
            this.BT_nuevo_mini.TabIndex = 2;
            this.BT_nuevo_mini.Text = "Nuevo";
            this.BT_nuevo_mini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_nuevo_mini.UseVisualStyleBackColor = false;
            this.BT_nuevo_mini.Click += new System.EventHandler(this.BT_nuevo_mini_Click);
            // 
            // BT_editar_mini
            // 
            this.BT_editar_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.BT_editar_mini.Location = new System.Drawing.Point(0, 62);
            this.BT_editar_mini.Name = "BT_editar_mini";
            this.BT_editar_mini.Size = new System.Drawing.Size(99, 38);
            this.BT_editar_mini.TabIndex = 3;
            this.BT_editar_mini.Text = "Editar";
            this.BT_editar_mini.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_editar_mini.UseVisualStyleBackColor = false;
            this.BT_editar_mini.Click += new System.EventHandler(this.BT_editar_mini_Click);
            // 
            // BT_excel
            // 
            this.BT_excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.BT_excel.Location = new System.Drawing.Point(0, 316);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(98, 38);
            this.BT_excel.TabIndex = 5;
            this.BT_excel.Text = "Excel";
            this.BT_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_excel.UseVisualStyleBackColor = false;
            this.BT_excel.Click += new System.EventHandler(this.BT_excel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.RB_emp_b);
            this.groupBox3.Controls.Add(this.RB_per_b);
            this.groupBox3.Controls.Add(this.BT_limpiar);
            this.groupBox3.Controls.Add(this.DGV_datos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.TX_buscar);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1002, 436);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar Proyectos";
            // 
            // RB_emp_b
            // 
            this.RB_emp_b.AutoSize = true;
            this.RB_emp_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_emp_b.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_emp_b.Location = new System.Drawing.Point(570, 28);
            this.RB_emp_b.Name = "RB_emp_b";
            this.RB_emp_b.Size = new System.Drawing.Size(85, 24);
            this.RB_emp_b.TabIndex = 34;
            this.RB_emp_b.TabStop = true;
            this.RB_emp_b.Text = "Empresa";
            this.RB_emp_b.UseVisualStyleBackColor = true;
            this.RB_emp_b.CheckedChanged += new System.EventHandler(this.RB_emp_b_CheckedChanged);
            // 
            // RB_per_b
            // 
            this.RB_per_b.AutoSize = true;
            this.RB_per_b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_per_b.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_per_b.Location = new System.Drawing.Point(685, 28);
            this.RB_per_b.Name = "RB_per_b";
            this.RB_per_b.Size = new System.Drawing.Size(81, 24);
            this.RB_per_b.TabIndex = 33;
            this.RB_per_b.TabStop = true;
            this.RB_per_b.Text = "Persona";
            this.RB_per_b.UseVisualStyleBackColor = true;
            this.RB_per_b.CheckedChanged += new System.EventHandler(this.RB_per_b_CheckedChanged);
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_datos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGV_datos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_datos.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_datos.EnableHeadersVisualStyles = false;
            this.DGV_datos.Location = new System.Drawing.Point(11, 62);
            this.DGV_datos.Name = "DGV_datos";
            this.DGV_datos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_datos.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_datos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_datos.Size = new System.Drawing.Size(881, 338);
            this.DGV_datos.TabIndex = 12;
            this.DGV_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_datos_CellContentClick);
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
            this.TP_administrar.Location = new System.Drawing.Point(4, 30);
            this.TP_administrar.Name = "TP_administrar";
            this.TP_administrar.Padding = new System.Windows.Forms.Padding(3);
            this.TP_administrar.Size = new System.Drawing.Size(1008, 442);
            this.TP_administrar.TabIndex = 0;
            this.TP_administrar.Text = "Administrar";
            this.TP_administrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DT_fin);
            this.groupBox1.Controls.Add(this.DT_inicio);
            this.groupBox1.Controls.Add(this.TX_identidad);
            this.groupBox1.Controls.Add(this.TX_nombre_p);
            this.groupBox1.Controls.Add(this.RB_emp);
            this.groupBox1.Controls.Add(this.RB_per);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TX_descripion);
            this.groupBox1.Controls.Add(this.TX_nombre);
            this.groupBox1.Controls.Add(this.TX_estado);
            this.groupBox1.Controls.Add(this.TX_id_proy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del  Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(625, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 39;
            this.label6.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Descripcion";
            // 
            // DT_fin
            // 
            this.DT_fin.CalendarFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fin.Enabled = false;
            this.DT_fin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_fin.Location = new System.Drawing.Point(729, 109);
            this.DT_fin.Name = "DT_fin";
            this.DT_fin.Size = new System.Drawing.Size(143, 27);
            this.DT_fin.TabIndex = 37;
            // 
            // DT_inicio
            // 
            this.DT_inicio.CalendarFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Enabled = false;
            this.DT_inicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DT_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DT_inicio.Location = new System.Drawing.Point(729, 70);
            this.DT_inicio.Name = "DT_inicio";
            this.DT_inicio.Size = new System.Drawing.Size(143, 27);
            this.DT_inicio.TabIndex = 36;
            // 
            // TX_identidad
            // 
            this.TX_identidad.BackColor = System.Drawing.SystemColors.Info;
            this.TX_identidad.Enabled = false;
            this.TX_identidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_identidad.Location = new System.Drawing.Point(141, 70);
            this.TX_identidad.Name = "TX_identidad";
            this.TX_identidad.Size = new System.Drawing.Size(215, 25);
            this.TX_identidad.TabIndex = 35;
            this.TX_identidad.Leave += new System.EventHandler(this.TX_identidad_Leave);
            // 
            // TX_nombre_p
            // 
            this.TX_nombre_p.Enabled = false;
            this.TX_nombre_p.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_nombre_p.Location = new System.Drawing.Point(376, 70);
            this.TX_nombre_p.Name = "TX_nombre_p";
            this.TX_nombre_p.Size = new System.Drawing.Size(187, 25);
            this.TX_nombre_p.TabIndex = 34;
            // 
            // RB_emp
            // 
            this.RB_emp.AutoSize = true;
            this.RB_emp.Enabled = false;
            this.RB_emp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_emp.Location = new System.Drawing.Point(788, 31);
            this.RB_emp.Name = "RB_emp";
            this.RB_emp.Size = new System.Drawing.Size(85, 24);
            this.RB_emp.TabIndex = 32;
            this.RB_emp.TabStop = true;
            this.RB_emp.Text = "Empresa";
            this.RB_emp.UseVisualStyleBackColor = true;
            this.RB_emp.CheckedChanged += new System.EventHandler(this.RB_emp_CheckedChanged);
            // 
            // RB_per
            // 
            this.RB_per.AutoSize = true;
            this.RB_per.Enabled = false;
            this.RB_per.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_per.Location = new System.Drawing.Point(691, 29);
            this.RB_per.Name = "RB_per";
            this.RB_per.Size = new System.Drawing.Size(81, 24);
            this.RB_per.TabIndex = 31;
            this.RB_per.TabStop = true;
            this.RB_per.Text = "Persona";
            this.RB_per.UseVisualStyleBackColor = true;
            this.RB_per.CheckedChanged += new System.EventHandler(this.RB_per_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Propietario";
            // 
            // TX_descripion
            // 
            this.TX_descripion.Enabled = false;
            this.TX_descripion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_descripion.Location = new System.Drawing.Point(140, 108);
            this.TX_descripion.Multiline = true;
            this.TX_descripion.Name = "TX_descripion";
            this.TX_descripion.Size = new System.Drawing.Size(423, 35);
            this.TX_descripion.TabIndex = 15;
            // 
            // TX_nombre
            // 
            this.TX_nombre.Enabled = false;
            this.TX_nombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_nombre.Location = new System.Drawing.Point(141, 28);
            this.TX_nombre.Name = "TX_nombre";
            this.TX_nombre.Size = new System.Drawing.Size(215, 25);
            this.TX_nombre.TabIndex = 28;
            // 
            // TX_estado
            // 
            this.TX_estado.Enabled = false;
            this.TX_estado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_estado.Location = new System.Drawing.Point(521, 28);
            this.TX_estado.Mask = ">?????????????????????????????";
            this.TX_estado.Name = "TX_estado";
            this.TX_estado.Size = new System.Drawing.Size(151, 25);
            this.TX_estado.TabIndex = 10;
            // 
            // TX_id_proy
            // 
            this.TX_id_proy.Enabled = false;
            this.TX_id_proy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_id_proy.Location = new System.Drawing.Point(376, 28);
            this.TX_id_proy.Name = "TX_id_proy";
            this.TX_id_proy.Size = new System.Drawing.Size(139, 25);
            this.TX_id_proy.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Proyecto";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.TX_linea);
            this.groupBox2.Controls.Add(this.DGV_detalle);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 274);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Producto";
            // 
            // TX_linea
            // 
            this.TX_linea.BackColor = System.Drawing.SystemColors.InfoText;
            this.TX_linea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_linea.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_linea.ForeColor = System.Drawing.Color.Chartreuse;
            this.TX_linea.Location = new System.Drawing.Point(5, 212);
            this.TX_linea.Name = "TX_linea";
            this.TX_linea.ReadOnly = true;
            this.TX_linea.Size = new System.Drawing.Size(107, 32);
            this.TX_linea.TabIndex = 40;
            this.TX_linea.Text = "0";
            this.TX_linea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGV_detalle
            // 
            this.DGV_detalle.AllowUserToAddRows = false;
            this.DGV_detalle.AllowUserToDeleteRows = false;
            this.DGV_detalle.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_detalle.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGV_detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_detalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGV_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_detalle.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGV_detalle.EnableHeadersVisualStyles = false;
            this.DGV_detalle.Location = new System.Drawing.Point(118, 40);
            this.DGV_detalle.Name = "DGV_detalle";
            this.DGV_detalle.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGV_detalle.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_detalle.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGV_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_detalle.Size = new System.Drawing.Size(752, 226);
            this.DGV_detalle.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.BT_eliminar_d);
            this.panel3.Controls.Add(this.BT_nuevo_d);
            this.panel3.Location = new System.Drawing.Point(6, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(103, 116);
            this.panel3.TabIndex = 35;
            // 
            // BT_eliminar_d
            // 
            this.BT_eliminar_d.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_eliminar_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_eliminar_d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_eliminar_d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_eliminar_d.Enabled = false;
            this.BT_eliminar_d.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_eliminar_d.FlatAppearance.BorderSize = 0;
            this.BT_eliminar_d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_eliminar_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_eliminar_d.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_eliminar_d.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_eliminar_d.Image = global::SIPRES.Properties.Resources.Eliminar24;
            this.BT_eliminar_d.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_eliminar_d.Location = new System.Drawing.Point(3, 47);
            this.BT_eliminar_d.Name = "BT_eliminar_d";
            this.BT_eliminar_d.Size = new System.Drawing.Size(103, 38);
            this.BT_eliminar_d.TabIndex = 16;
            this.BT_eliminar_d.Text = "Eliminar";
            this.BT_eliminar_d.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_eliminar_d.UseVisualStyleBackColor = false;
            this.BT_eliminar_d.Click += new System.EventHandler(this.BT_eliminar_d_Click);
            // 
            // BT_nuevo_d
            // 
            this.BT_nuevo_d.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_nuevo_d.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.BT_nuevo_d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_nuevo_d.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_nuevo_d.Enabled = false;
            this.BT_nuevo_d.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_nuevo_d.FlatAppearance.BorderSize = 0;
            this.BT_nuevo_d.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_nuevo_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_nuevo_d.Font = new System.Drawing.Font("Poppins Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_nuevo_d.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_nuevo_d.Image = global::SIPRES.Properties.Resources.Nuevo24;
            this.BT_nuevo_d.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_nuevo_d.Location = new System.Drawing.Point(3, 3);
            this.BT_nuevo_d.Name = "BT_nuevo_d";
            this.BT_nuevo_d.Size = new System.Drawing.Size(100, 38);
            this.BT_nuevo_d.TabIndex = 7;
            this.BT_nuevo_d.Text = "Agregar";
            this.BT_nuevo_d.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_nuevo_d.UseVisualStyleBackColor = false;
            this.BT_nuevo_d.Click += new System.EventHandler(this.BT_nuevo_d_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.BT_cancelar);
            this.panel1.Controls.Add(this.BT_editar);
            this.panel1.Controls.Add(this.BT_guardar);
            this.panel1.Controls.Add(this.BT_nuevo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(893, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 436);
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
            this.BT_cancelar.Location = new System.Drawing.Point(1, 373);
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
            this.BT_editar.Location = new System.Drawing.Point(3, 291);
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
            this.BT_guardar.Location = new System.Drawing.Point(3, 332);
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
            this.BT_nuevo.Location = new System.Drawing.Point(4, 250);
            this.BT_nuevo.Name = "BT_nuevo";
            this.BT_nuevo.Size = new System.Drawing.Size(107, 38);
            this.BT_nuevo.TabIndex = 7;
            this.BT_nuevo.Text = "Nuevo  ";
            this.BT_nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_nuevo.UseVisualStyleBackColor = false;
            this.BT_nuevo.Click += new System.EventHandler(this.BT_nuevo_Click);
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
            this.BT_salir.TabIndex = 37;
            this.BT_salir.Text = "X";
            this.BT_salir.UseVisualStyleBackColor = false;
            this.BT_salir.Click += new System.EventHandler(this.BT_salir_Click);
            // 
            // SFD_pdf
            // 
            this.SFD_pdf.FileName = ".pdf";
            this.SFD_pdf.Filter = "\"Archivo PDF|*.pdf\"";
            this.SFD_pdf.InitialDirectory = "C:\\Sipres\\Reportes\\PDF";
            this.SFD_pdf.Title = "Exportar a PDF";
            // 
            // SFD_excel
            // 
            this.SFD_excel.Filter = "\"Archivo CSV|*.csv\"";
            this.SFD_excel.InitialDirectory = "C:\\Sipres\\Reportes\\Excel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SIPRES.Properties.Resources.proyecto;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 476);
            this.Controls.Add(this.BT_salir);
            this.Controls.Add(this.TC_proyecto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "proyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "proyecto";
            this.Load += new System.EventHandler(this.Proyecto_Load);
            this.TC_proyecto.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detalle)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TC_proyecto;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TX_nombre;
        private System.Windows.Forms.MaskedTextBox TX_estado;
        private System.Windows.Forms.MaskedTextBox TX_id_proy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TX_descripion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Button BT_editar;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Button BT_nuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton RB_emp;
        private System.Windows.Forms.RadioButton RB_per;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_nuevo_d;
        private System.Windows.Forms.DataGridView DGV_detalle;
        private System.Windows.Forms.MaskedTextBox TX_nombre_p;
        private System.Windows.Forms.MaskedTextBox TX_identidad;
        private System.Windows.Forms.TextBox TX_linea;
        private System.Windows.Forms.RadioButton RB_emp_b;
        private System.Windows.Forms.RadioButton RB_per_b;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_fin;
        private System.Windows.Forms.DateTimePicker DT_inicio;
        private System.Windows.Forms.Button BT_ver;
        private System.Windows.Forms.Button BT_eliminar_d;
        private System.Windows.Forms.Button BT_salir;
        private System.Windows.Forms.SaveFileDialog SFD_pdf;
        private System.Windows.Forms.SaveFileDialog SFD_excel;
        private System.Windows.Forms.Button BT_imprimir;
    }
}