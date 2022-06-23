namespace PlantillaInicioProyecto
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxUsuario = new System.Windows.Forms.TextBox();
            this.boxContrasenia = new System.Windows.Forms.TextBox();
            this.botonAcceder = new System.Windows.Forms.Button();
            this.botonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡¡¡BIENVENIDO AL SISTEMA!!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inicio de sesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(140, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(140, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña";
            // 
            // boxUsuario
            // 
            this.boxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.boxUsuario.Location = new System.Drawing.Point(317, 115);
            this.boxUsuario.Name = "boxUsuario";
            this.boxUsuario.Size = new System.Drawing.Size(138, 30);
            this.boxUsuario.TabIndex = 6;
            // 
            // boxContrasenia
            // 
            this.boxContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.boxContrasenia.Location = new System.Drawing.Point(317, 181);
            this.boxContrasenia.Name = "boxContrasenia";
            this.boxContrasenia.PasswordChar = '*';
            this.boxContrasenia.Size = new System.Drawing.Size(138, 30);
            this.boxContrasenia.TabIndex = 7;
            // 
            // botonAcceder
            // 
            this.botonAcceder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonAcceder.BackgroundImage")));
            this.botonAcceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonAcceder.Location = new System.Drawing.Point(479, 166);
            this.botonAcceder.Name = "botonAcceder";
            this.botonAcceder.Size = new System.Drawing.Size(45, 45);
            this.botonAcceder.TabIndex = 10;
            this.botonAcceder.UseVisualStyleBackColor = true;
            this.botonAcceder.Click += new System.EventHandler(this.botonAcceder_Click);
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonLimpiar.BackgroundImage")));
            this.botonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonLimpiar.Location = new System.Drawing.Point(479, 106);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(45, 45);
            this.botonLimpiar.TabIndex = 11;
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(551, 278);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.botonAcceder);
            this.Controls.Add(this.boxContrasenia);
            this.Controls.Add(this.boxUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox boxUsuario;
        private System.Windows.Forms.TextBox boxContrasenia;
        private System.Windows.Forms.Button botonAcceder;
        private System.Windows.Forms.Button botonLimpiar;
    }
}

