namespace SIPRES.Vistas
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_salir = new System.Windows.Forms.Button();
            this.BT_persona = new System.Windows.Forms.Button();
            this.BT_proyecto = new System.Windows.Forms.Button();
            this.BT_usuario = new System.Windows.Forms.Button();
            this.BT_producto = new System.Windows.Forms.Button();
            this.BT_cliente = new System.Windows.Forms.Button();
            this.P_formulario = new System.Windows.Forms.Panel();
            this.PB_logo2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Barra_estado = new System.Windows.Forms.StatusStrip();
            this.activo = new System.Windows.Forms.ToolStripStatusLabel();
            this.rol = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.P_formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo2)).BeginInit();
            this.Barra_estado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.BT_salir);
            this.panel1.Controls.Add(this.BT_persona);
            this.panel1.Controls.Add(this.BT_proyecto);
            this.panel1.Controls.Add(this.BT_usuario);
            this.panel1.Controls.Add(this.BT_producto);
            this.panel1.Controls.Add(this.BT_cliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 58);
            this.panel1.TabIndex = 0;
            // 
            // BT_salir
            // 
            this.BT_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_salir.FlatAppearance.BorderSize = 0;
            this.BT_salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_salir.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_salir.Image = global::SIPRES.Properties.Resources.salir;
            this.BT_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_salir.Location = new System.Drawing.Point(993, 0);
            this.BT_salir.Name = "BT_salir";
            this.BT_salir.Size = new System.Drawing.Size(115, 58);
            this.BT_salir.TabIndex = 47;
            this.BT_salir.Text = "Salir";
            this.BT_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_salir.UseVisualStyleBackColor = false;
            this.BT_salir.Click += new System.EventHandler(this.BT_salir_Click);
            // 
            // BT_persona
            // 
            this.BT_persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_persona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_persona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_persona.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_persona.Enabled = false;
            this.BT_persona.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_persona.FlatAppearance.BorderSize = 0;
            this.BT_persona.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_persona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_persona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_persona.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_persona.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_persona.Image = global::SIPRES.Properties.Resources.persona;
            this.BT_persona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_persona.Location = new System.Drawing.Point(5, 4);
            this.BT_persona.Name = "BT_persona";
            this.BT_persona.Size = new System.Drawing.Size(151, 50);
            this.BT_persona.TabIndex = 41;
            this.BT_persona.Text = "Persona";
            this.BT_persona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_persona.UseVisualStyleBackColor = false;
            this.BT_persona.Click += new System.EventHandler(this.BT_persona_Click);
            // 
            // BT_proyecto
            // 
            this.BT_proyecto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_proyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_proyecto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_proyecto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_proyecto.Enabled = false;
            this.BT_proyecto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_proyecto.FlatAppearance.BorderSize = 0;
            this.BT_proyecto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_proyecto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_proyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_proyecto.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_proyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_proyecto.Image = global::SIPRES.Properties.Resources.prestamo;
            this.BT_proyecto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_proyecto.Location = new System.Drawing.Point(634, 4);
            this.BT_proyecto.Name = "BT_proyecto";
            this.BT_proyecto.Size = new System.Drawing.Size(151, 50);
            this.BT_proyecto.TabIndex = 45;
            this.BT_proyecto.Text = "Proyecto";
            this.BT_proyecto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_proyecto.UseVisualStyleBackColor = false;
            // 
            // BT_usuario
            // 
            this.BT_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_usuario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_usuario.Enabled = false;
            this.BT_usuario.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_usuario.FlatAppearance.BorderSize = 0;
            this.BT_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_usuario.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_usuario.Image = global::SIPRES.Properties.Resources.usuario;
            this.BT_usuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_usuario.Location = new System.Drawing.Point(162, 4);
            this.BT_usuario.Name = "BT_usuario";
            this.BT_usuario.Size = new System.Drawing.Size(151, 50);
            this.BT_usuario.TabIndex = 42;
            this.BT_usuario.Text = "Usuario";
            this.BT_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_usuario.UseVisualStyleBackColor = false;
            // 
            // BT_producto
            // 
            this.BT_producto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_producto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_producto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_producto.Enabled = false;
            this.BT_producto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_producto.FlatAppearance.BorderSize = 0;
            this.BT_producto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_producto.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_producto.Image = global::SIPRES.Properties.Resources.Cuentas;
            this.BT_producto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_producto.Location = new System.Drawing.Point(476, 4);
            this.BT_producto.Name = "BT_producto";
            this.BT_producto.Size = new System.Drawing.Size(151, 50);
            this.BT_producto.TabIndex = 44;
            this.BT_producto.Text = "Producto";
            this.BT_producto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_producto.UseVisualStyleBackColor = false;
            // 
            // BT_cliente
            // 
            this.BT_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_cliente.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_cliente.Enabled = false;
            this.BT_cliente.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_cliente.FlatAppearance.BorderSize = 0;
            this.BT_cliente.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.BT_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_cliente.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_cliente.Image = ((System.Drawing.Image)(resources.GetObject("BT_cliente.Image")));
            this.BT_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_cliente.Location = new System.Drawing.Point(319, 4);
            this.BT_cliente.Name = "BT_cliente";
            this.BT_cliente.Size = new System.Drawing.Size(151, 50);
            this.BT_cliente.TabIndex = 43;
            this.BT_cliente.Text = "Cliente";
            this.BT_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_cliente.UseVisualStyleBackColor = false;
            // 
            // P_formulario
            // 
            this.P_formulario.BackColor = System.Drawing.Color.Transparent;
            this.P_formulario.Controls.Add(this.PB_logo2);
            this.P_formulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_formulario.Location = new System.Drawing.Point(0, 82);
            this.P_formulario.Name = "P_formulario";
            this.P_formulario.Size = new System.Drawing.Size(1108, 584);
            this.P_formulario.TabIndex = 3;
            // 
            // PB_logo2
            // 
            this.PB_logo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_logo2.Image = ((System.Drawing.Image)(resources.GetObject("PB_logo2.Image")));
            this.PB_logo2.Location = new System.Drawing.Point(0, 0);
            this.PB_logo2.Name = "PB_logo2";
            this.PB_logo2.Size = new System.Drawing.Size(1108, 584);
            this.PB_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PB_logo2.TabIndex = 1;
            this.PB_logo2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Barra_estado
            // 
            this.Barra_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.Barra_estado.Font = new System.Drawing.Font("Poppins Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Barra_estado.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Barra_estado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activo,
            this.rol});
            this.Barra_estado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Barra_estado.Location = new System.Drawing.Point(0, 635);
            this.Barra_estado.Name = "Barra_estado";
            this.Barra_estado.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Barra_estado.Size = new System.Drawing.Size(1108, 31);
            this.Barra_estado.TabIndex = 5;
            this.Barra_estado.Text = "statusStrip1";
            // 
            // activo
            // 
            this.activo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.activo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.activo.Name = "activo";
            this.activo.Size = new System.Drawing.Size(115, 26);
            this.activo.Text = "Usuario Activo";
            // 
            // rol
            // 
            this.rol.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.rol.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.rol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(99, 26);
            this.rol.Text = "Rol usuarios";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1108, 666);
            this.Controls.Add(this.Barra_estado);
            this.Controls.Add(this.P_formulario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal";
            this.Text = "Sistema Presupuestario";
            this.panel1.ResumeLayout(false);
            this.P_formulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo2)).EndInit();
            this.Barra_estado.ResumeLayout(false);
            this.Barra_estado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_persona;
        private System.Windows.Forms.Button BT_usuario;
        private System.Windows.Forms.Button BT_salir;
        private System.Windows.Forms.Button BT_proyecto;
        private System.Windows.Forms.Button BT_producto;
        private System.Windows.Forms.Button BT_cliente;
        private System.Windows.Forms.Panel P_formulario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip Barra_estado;
        private System.Windows.Forms.ToolStripStatusLabel activo;
        private System.Windows.Forms.ToolStripStatusLabel rol;
        private System.Windows.Forms.PictureBox PB_logo2;
    }
}