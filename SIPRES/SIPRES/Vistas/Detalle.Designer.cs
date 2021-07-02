namespace SIPRES.Vistas
{
    partial class Detalle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detalle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TX_precio = new System.Windows.Forms.MaskedTextBox();
            this.TX_unidad = new System.Windows.Forms.MaskedTextBox();
            this.TX_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TX_cantidad = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TX_producto = new System.Windows.Forms.MaskedTextBox();
            this.TX_codigo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BT_cancelar = new System.Windows.Forms.Button();
            this.Bt_aseptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TX_precio);
            this.groupBox1.Controls.Add(this.TX_unidad);
            this.groupBox1.Controls.Add(this.TX_total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TX_cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TX_producto);
            this.groupBox1.Controls.Add(this.TX_codigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 220);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del  Producto";
            // 
            // TX_precio
            // 
            this.TX_precio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_precio.Location = new System.Drawing.Point(113, 166);
            this.TX_precio.Name = "TX_precio";
            this.TX_precio.ReadOnly = true;
            this.TX_precio.Size = new System.Drawing.Size(101, 27);
            this.TX_precio.TabIndex = 43;
            // 
            // TX_unidad
            // 
            this.TX_unidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_unidad.Location = new System.Drawing.Point(322, 124);
            this.TX_unidad.Name = "TX_unidad";
            this.TX_unidad.ReadOnly = true;
            this.TX_unidad.Size = new System.Drawing.Size(101, 27);
            this.TX_unidad.TabIndex = 42;
            // 
            // TX_total
            // 
            this.TX_total.BackColor = System.Drawing.SystemColors.InfoText;
            this.TX_total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_total.ForeColor = System.Drawing.Color.YellowGreen;
            this.TX_total.Location = new System.Drawing.Point(322, 169);
            this.TX_total.Name = "TX_total";
            this.TX_total.ReadOnly = true;
            this.TX_total.Size = new System.Drawing.Size(101, 29);
            this.TX_total.TabIndex = 41;
            this.TX_total.Text = "0";
            this.TX_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Precio";
            // 
            // TX_cantidad
            // 
            this.TX_cantidad.BackColor = System.Drawing.SystemColors.Info;
            this.TX_cantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_cantidad.Location = new System.Drawing.Point(113, 124);
            this.TX_cantidad.Mask = "000000";
            this.TX_cantidad.Name = "TX_cantidad";
            this.TX_cantidad.Size = new System.Drawing.Size(101, 27);
            this.TX_cantidad.TabIndex = 30;
            this.TX_cantidad.Leave += new System.EventHandler(this.TX_cantidad_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Unidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Producto";
            // 
            // TX_producto
            // 
            this.TX_producto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_producto.Location = new System.Drawing.Point(113, 81);
            this.TX_producto.Name = "TX_producto";
            this.TX_producto.ReadOnly = true;
            this.TX_producto.Size = new System.Drawing.Size(310, 27);
            this.TX_producto.TabIndex = 26;
            // 
            // TX_codigo
            // 
            this.TX_codigo.BackColor = System.Drawing.SystemColors.Info;
            this.TX_codigo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_codigo.Location = new System.Drawing.Point(113, 39);
            this.TX_codigo.Mask = "000-0000";
            this.TX_codigo.Name = "TX_codigo";
            this.TX_codigo.Size = new System.Drawing.Size(181, 27);
            this.TX_codigo.TabIndex = 8;
            this.TX_codigo.TextChanged += new System.EventHandler(this.TX_codigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.BT_cancelar);
            this.panel3.Controls.Add(this.Bt_aseptar);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 263);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 38);
            this.panel3.TabIndex = 36;
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
            this.BT_cancelar.Location = new System.Drawing.Point(348, 3);
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
            this.Bt_aseptar.Location = new System.Drawing.Point(233, 0);
            this.Bt_aseptar.Name = "Bt_aseptar";
            this.Bt_aseptar.Size = new System.Drawing.Size(109, 38);
            this.Bt_aseptar.TabIndex = 16;
            this.Bt_aseptar.Text = "Aceptar";
            this.Bt_aseptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bt_aseptar.UseVisualStyleBackColor = false;
            this.Bt_aseptar.Click += new System.EventHandler(this.Bt_aseptar_Click);
            // 
            // Detalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 301);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TX_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox TX_producto;
        private System.Windows.Forms.MaskedTextBox TX_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TX_unidad;
        private System.Windows.Forms.TextBox TX_total;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BT_cancelar;
        private System.Windows.Forms.Button Bt_aseptar;
        private System.Windows.Forms.MaskedTextBox TX_precio;
    }
}