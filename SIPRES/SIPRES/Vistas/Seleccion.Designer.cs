namespace SIPRES.Vistas
{
    partial class seleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seleccion));
            this.BT_limpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TX_buscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.Bt_aseptar = new System.Windows.Forms.Button();
            this.DGV_detalle = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detalle)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_limpiar
            // 
            this.BT_limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_limpiar.Image = global::SIPRES.Properties.Resources.limpiar24;
            this.BT_limpiar.Location = new System.Drawing.Point(437, 12);
            this.BT_limpiar.Name = "BT_limpiar";
            this.BT_limpiar.Size = new System.Drawing.Size(28, 29);
            this.BT_limpiar.TabIndex = 44;
            this.BT_limpiar.UseVisualStyleBackColor = true;
            this.BT_limpiar.Click += new System.EventHandler(this.BT_limpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Busqueda";
            // 
            // TX_buscar
            // 
            this.TX_buscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_buscar.Location = new System.Drawing.Point(144, 11);
            this.TX_buscar.Name = "TX_buscar";
            this.TX_buscar.Size = new System.Drawing.Size(278, 29);
            this.TX_buscar.TabIndex = 43;
            this.TX_buscar.TextChanged += new System.EventHandler(this.TX_buscar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.BT_cancelar);
            this.panel3.Controls.Add(this.Bt_aseptar);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 256);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(561, 38);
            this.panel3.TabIndex = 46;
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
            this.BT_cancelar.Location = new System.Drawing.Point(437, 3);
            this.BT_cancelar.Name = "BT_cancelar";
            this.BT_cancelar.Size = new System.Drawing.Size(124, 38);
            this.BT_cancelar.TabIndex = 17;
            this.BT_cancelar.Text = "Cancelar";
            this.BT_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_cancelar.UseVisualStyleBackColor = false;
            this.BT_cancelar.Click += new System.EventHandler(this.BT_cancelar_Click);
            // 
            // Bt_aseptar
            // 
            this.Bt_aseptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_aseptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Bt_aseptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_aseptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bt_aseptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Bt_aseptar.FlatAppearance.BorderSize = 0;
            this.Bt_aseptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Bt_aseptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_aseptar.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_aseptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bt_aseptar.Image = global::SIPRES.Properties.Resources.Aplicar224;
            this.Bt_aseptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bt_aseptar.Location = new System.Drawing.Point(322, 0);
            this.Bt_aseptar.Name = "Bt_aseptar";
            this.Bt_aseptar.Size = new System.Drawing.Size(109, 38);
            this.Bt_aseptar.TabIndex = 16;
            this.Bt_aseptar.Text = "Aceptar";
            this.Bt_aseptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_aseptar.UseVisualStyleBackColor = false;
            this.Bt_aseptar.Click += new System.EventHandler(this.Bt_aseptar_Click);
            // 
            // DGV_detalle
            // 
            this.DGV_detalle.AllowUserToAddRows = false;
            this.DGV_detalle.AllowUserToDeleteRows = false;
            this.DGV_detalle.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_detalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_detalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_detalle.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DGV_detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_detalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_detalle.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_detalle.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_detalle.EnableHeadersVisualStyles = false;
            this.DGV_detalle.Location = new System.Drawing.Point(12, 47);
            this.DGV_detalle.Name = "DGV_detalle";
            this.DGV_detalle.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_detalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_detalle.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_detalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_detalle.Size = new System.Drawing.Size(537, 191);
            this.DGV_detalle.TabIndex = 47;
            this.DGV_detalle.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_detalle_CellContentDoubleClick);
            // 
            // seleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 294);
            this.Controls.Add(this.DGV_detalle);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BT_limpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TX_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccion";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_detalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BT_limpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TX_buscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Button Bt_aseptar;
        private System.Windows.Forms.DataGridView DGV_detalle;
    }
}