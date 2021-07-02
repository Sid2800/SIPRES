namespace SIPRES.Vistas
{
    partial class producto
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
            this.TC_producto = new System.Windows.Forms.TabControl();
            this.TP_listar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DGV_datos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.TX_buscar = new System.Windows.Forms.TextBox();
            this.TP_administrar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TX_nombre = new System.Windows.Forms.MaskedTextBox();
            this.TX_descripcion = new System.Windows.Forms.MaskedTextBox();
            this.TX_codigo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TX_descripion_t = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_pdf = new System.Windows.Forms.Button();
            this.BT_nuevo_mini = new System.Windows.Forms.Button();
            this.BT_editar_mini = new System.Windows.Forms.Button();
            this.BT_excel = new System.Windows.Forms.Button();
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.BT_editar = new System.Windows.Forms.Button();
            this.BT_guardar = new System.Windows.Forms.Button();
            this.BT_nuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TX_unidad = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TX_precio = new System.Windows.Forms.MaskedTextBox();
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            this.TC_producto.SuspendLayout();
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
            // TC_producto
            // 
            this.TC_producto.Controls.Add(this.TP_listar);
            this.TC_producto.Controls.Add(this.TP_administrar);
            this.TC_producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TC_producto.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TC_producto.Location = new System.Drawing.Point(60, 0);
            this.TC_producto.Margin = new System.Windows.Forms.Padding(6);
            this.TC_producto.Name = "TC_producto";
            this.TC_producto.SelectedIndex = 0;
            this.TC_producto.Size = new System.Drawing.Size(1032, 515);
            this.TC_producto.TabIndex = 34;
            // 
            // TP_listar
            // 
            this.TP_listar.BackColor = System.Drawing.Color.Transparent;
            this.TP_listar.Controls.Add(this.panel2);
            this.TP_listar.Controls.Add(this.groupBox3);
            this.TP_listar.Font = new System.Drawing.Font("Abecedary", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_listar.Location = new System.Drawing.Point(4, 34);
            this.TP_listar.Name = "TP_listar";
            this.TP_listar.Padding = new System.Windows.Forms.Padding(3);
            this.TP_listar.Size = new System.Drawing.Size(1024, 477);
            this.TP_listar.TabIndex = 1;
            this.TP_listar.Text = "Listar";
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
            this.panel2.Size = new System.Drawing.Size(92, 471);
            this.panel2.TabIndex = 31;
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
            this.groupBox3.Size = new System.Drawing.Size(1018, 471);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar productos";
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
            this.DGV_datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DGV_datos.Location = new System.Drawing.Point(9, 62);
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
            this.DGV_datos.Size = new System.Drawing.Size(904, 373);
            this.DGV_datos.TabIndex = 12;
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
            // 
            // TP_administrar
            // 
            this.TP_administrar.Controls.Add(this.groupBox1);
            this.TP_administrar.Controls.Add(this.groupBox2);
            this.TP_administrar.Controls.Add(this.panel1);
            this.TP_administrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TP_administrar.Location = new System.Drawing.Point(4, 34);
            this.TP_administrar.Name = "TP_administrar";
            this.TP_administrar.Padding = new System.Windows.Forms.Padding(3);
            this.TP_administrar.Size = new System.Drawing.Size(1024, 477);
            this.TP_administrar.TabIndex = 0;
            this.TP_administrar.Text = "Administrar";
            this.TP_administrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TX_precio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TX_unidad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TX_nombre);
            this.groupBox1.Controls.Add(this.TX_descripcion);
            this.groupBox1.Controls.Add(this.TX_codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del  Producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(475, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Nombre";
            // 
            // TX_nombre
            // 
            this.TX_nombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_nombre.Location = new System.Drawing.Point(570, 36);
            this.TX_nombre.Name = "TX_nombre";
            this.TX_nombre.ReadOnly = true;
            this.TX_nombre.Size = new System.Drawing.Size(285, 27);
            this.TX_nombre.TabIndex = 26;
            // 
            // TX_descripcion
            // 
            this.TX_descripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_descripcion.Location = new System.Drawing.Point(137, 94);
            this.TX_descripcion.Mask = ">?????????????????????????????";
            this.TX_descripcion.Name = "TX_descripcion";
            this.TX_descripcion.ReadOnly = true;
            this.TX_descripcion.Size = new System.Drawing.Size(718, 27);
            this.TX_descripcion.TabIndex = 10;
            // 
            // TX_codigo
            // 
            this.TX_codigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_codigo.Location = new System.Drawing.Point(139, 39);
            this.TX_codigo.Name = "TX_codigo";
            this.TX_codigo.ReadOnly = true;
            this.TX_codigo.Size = new System.Drawing.Size(285, 27);
            this.TX_codigo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CB_Tipo);
            this.groupBox2.Controls.Add(this.TX_descripion_t);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(879, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Producto";
            // 
            // TX_descripion_t
            // 
            this.TX_descripion_t.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_descripion_t.Location = new System.Drawing.Point(139, 92);
            this.TX_descripion_t.Name = "TX_descripion_t";
            this.TX_descripion_t.ReadOnly = true;
            this.TX_descripion_t.Size = new System.Drawing.Size(716, 27);
            this.TX_descripion_t.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo";
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
            this.panel1.Size = new System.Drawing.Size(112, 471);
            this.panel1.TabIndex = 34;
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
            this.BT_pdf.Location = new System.Drawing.Point(2, 395);
            this.BT_pdf.Name = "BT_pdf";
            this.BT_pdf.Size = new System.Drawing.Size(89, 38);
            this.BT_pdf.TabIndex = 4;
            this.BT_pdf.Text = "PDF";
            this.BT_pdf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_pdf.UseVisualStyleBackColor = false;
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
            this.BT_excel.Location = new System.Drawing.Point(2, 351);
            this.BT_excel.Name = "BT_excel";
            this.BT_excel.Size = new System.Drawing.Size(89, 38);
            this.BT_excel.TabIndex = 5;
            this.BT_excel.Text = "Excel";
            this.BT_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_excel.UseVisualStyleBackColor = false;
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.Image = global::SIPRES.Properties.Resources.limpiar24;
            this.BT_limpiar.Location = new System.Drawing.Point(423, 24);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(28, 29);
            this.BT_limpiar.TabIndex = 1;
            this.BT_limpiar.UseVisualStyleBackColor = true;
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SIPRES.Properties.Resources.productor;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Unidad";
            // 
            // TX_unidad
            // 
            this.TX_unidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_unidad.Location = new System.Drawing.Point(137, 147);
            this.TX_unidad.Name = "TX_unidad";
            this.TX_unidad.ReadOnly = true;
            this.TX_unidad.Size = new System.Drawing.Size(285, 27);
            this.TX_unidad.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Precio";
            // 
            // TX_precio
            // 
            this.TX_precio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_precio.Location = new System.Drawing.Point(572, 151);
            this.TX_precio.Name = "TX_precio";
            this.TX_precio.ReadOnly = true;
            this.TX_precio.Size = new System.Drawing.Size(285, 27);
            this.TX_precio.TabIndex = 30;
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.Enabled = false;
            this.CB_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_Tipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CB_Tipo.Location = new System.Drawing.Point(139, 36);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(287, 28);
            this.CB_Tipo.TabIndex = 27;
            // 
            // producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 515);
            this.Controls.Add(this.TC_producto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "producto";
            this.Text = "producto";
            this.TC_producto.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl TC_producto;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TX_nombre;
        private System.Windows.Forms.MaskedTextBox TX_descripcion;
        private System.Windows.Forms.MaskedTextBox TX_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TX_descripion_t;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Button BT_editar;
        private System.Windows.Forms.Button BT_guardar;
        private System.Windows.Forms.Button BT_nuevo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TX_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox TX_unidad;
        private System.Windows.Forms.ComboBox CB_Tipo;
    }
}