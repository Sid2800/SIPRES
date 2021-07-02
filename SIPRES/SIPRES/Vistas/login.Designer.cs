namespace SIPRES.Vistas
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.BT_salir = new System.Windows.Forms.Button();
            this.BT_ingresar = new System.Windows.Forms.Button();
            this.CB_id_usu = new System.Windows.Forms.ComboBox();
            this.LBpassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TX_contra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_salir
            // 
            this.BT_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_salir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_salir.FlatAppearance.BorderSize = 0;
            this.BT_salir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.BT_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_salir.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_salir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_salir.Image = global::SIPRES.Properties.Resources.Cacelar24;
            this.BT_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_salir.Location = new System.Drawing.Point(268, 415);
            this.BT_salir.Name = "BT_salir";
            this.BT_salir.Size = new System.Drawing.Size(122, 37);
            this.BT_salir.TabIndex = 41;
            this.BT_salir.Text = "Salir     ";
            this.BT_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_salir.UseVisualStyleBackColor = false;
            this.BT_salir.Click += new System.EventHandler(this.BT_salir_Click);
            // 
            // BT_ingresar
            // 
            this.BT_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.BT_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BT_ingresar.FlatAppearance.BorderSize = 0;
            this.BT_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Info;
            this.BT_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.BT_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ingresar.Font = new System.Drawing.Font("Poppins Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ingresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BT_ingresar.Image = global::SIPRES.Properties.Resources.Aplicar224;
            this.BT_ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_ingresar.Location = new System.Drawing.Point(124, 415);
            this.BT_ingresar.Name = "BT_ingresar";
            this.BT_ingresar.Size = new System.Drawing.Size(121, 37);
            this.BT_ingresar.TabIndex = 40;
            this.BT_ingresar.Text = "Ingresar";
            this.BT_ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BT_ingresar.UseVisualStyleBackColor = false;
            this.BT_ingresar.Click += new System.EventHandler(this.BT_ingresar_Click);
            // 
            // CB_id_usu
            // 
            this.CB_id_usu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.CB_id_usu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CB_id_usu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_id_usu.ForeColor = System.Drawing.SystemColors.Window;
            this.CB_id_usu.FormattingEnabled = true;
            this.CB_id_usu.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.CB_id_usu.Location = new System.Drawing.Point(170, 289);
            this.CB_id_usu.Name = "CB_id_usu";
            this.CB_id_usu.Size = new System.Drawing.Size(225, 28);
            this.CB_id_usu.TabIndex = 39;
            // 
            // LBpassword
            // 
            this.LBpassword.AutoSize = true;
            this.LBpassword.BackColor = System.Drawing.Color.Transparent;
            this.LBpassword.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBpassword.ForeColor = System.Drawing.SystemColors.Control;
            this.LBpassword.Location = new System.Drawing.Point(58, 356);
            this.LBpassword.Name = "LBpassword";
            this.LBpassword.Size = new System.Drawing.Size(101, 21);
            this.LBpassword.TabIndex = 38;
            this.LBpassword.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Usuario";
            // 
            // TX_contra
            // 
            this.TX_contra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.TX_contra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_contra.ForeColor = System.Drawing.SystemColors.Window;
            this.TX_contra.Location = new System.Drawing.Point(170, 350);
            this.TX_contra.Name = "TX_contra";
            this.TX_contra.PasswordChar = '✘';
            this.TX_contra.Size = new System.Drawing.Size(225, 29);
            this.TX_contra.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trajan Pro", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(151, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 48);
            this.label1.TabIndex = 42;
            this.label1.Text = "SIPRES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_salir);
            this.Controls.Add(this.BT_ingresar);
            this.Controls.Add(this.CB_id_usu);
            this.Controls.Add(this.LBpassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TX_contra);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.BT_ingresar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_salir;
        private System.Windows.Forms.Button BT_ingresar;
        private System.Windows.Forms.ComboBox CB_id_usu;
        private System.Windows.Forms.Label LBpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TX_contra;
        private System.Windows.Forms.Label label1;
    }
}