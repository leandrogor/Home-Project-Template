namespace PlantillaInicioProyecto
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblUsIngresado = new System.Windows.Forms.Label();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.fechaHora = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aMBAulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMáquinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMTrabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listado1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listado2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listado3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadística1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadística2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadística3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceso1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceso2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proceso3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsIngresado
            // 
            this.lblUsIngresado.AutoSize = true;
            this.lblUsIngresado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblUsIngresado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsIngresado.Location = new System.Drawing.Point(12, 410);
            this.lblUsIngresado.Name = "lblUsIngresado";
            this.lblUsIngresado.Size = new System.Drawing.Size(249, 31);
            this.lblUsIngresado.TabIndex = 0;
            this.lblUsIngresado.Text = "Usuario ingresado: ";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFechaHora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaHora.Location = new System.Drawing.Point(379, 410);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaHora.Size = new System.Drawing.Size(417, 29);
            this.lblFechaHora.TabIndex = 5;
            this.lblFechaHora.Text = "[FechaHora]";
            this.lblFechaHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fechaHora
            // 
            this.fechaHora.Enabled = true;
            this.fechaHora.Tick += new System.EventHandler(this.fechaHora_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sistemToolStripMenuItem,
            this.aMBToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.estadísticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // sistemToolStripMenuItem
            // 
            this.sistemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.sistemToolStripMenuItem.Name = "sistemToolStripMenuItem";
            this.sistemToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemToolStripMenuItem.Text = "Sistema";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMUsuariosToolStripMenuItem,
            this.cambiarPasswordToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // aBMUsuariosToolStripMenuItem
            // 
            this.aBMUsuariosToolStripMenuItem.Name = "aBMUsuariosToolStripMenuItem";
            this.aBMUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aBMUsuariosToolStripMenuItem.Text = "ABM Usuarios";
            // 
            // cambiarPasswordToolStripMenuItem
            // 
            this.cambiarPasswordToolStripMenuItem.Name = "cambiarPasswordToolStripMenuItem";
            this.cambiarPasswordToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cambiarPasswordToolStripMenuItem.Text = "Cambiar Password";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // aMBToolStripMenuItem
            // 
            this.aMBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aMBAulasToolStripMenuItem,
            this.aBMEstudiantesToolStripMenuItem,
            this.aBMMáquinasToolStripMenuItem,
            this.aBMTrabajosToolStripMenuItem,
            this.aBMMantenimientoToolStripMenuItem});
            this.aMBToolStripMenuItem.Name = "aMBToolStripMenuItem";
            this.aMBToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aMBToolStripMenuItem.Text = "ABM";
            // 
            // aMBAulasToolStripMenuItem
            // 
            this.aMBAulasToolStripMenuItem.Name = "aMBAulasToolStripMenuItem";
            this.aMBAulasToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aMBAulasToolStripMenuItem.Text = "ABM Aulas";
            // 
            // aBMEstudiantesToolStripMenuItem
            // 
            this.aBMEstudiantesToolStripMenuItem.Name = "aBMEstudiantesToolStripMenuItem";
            this.aBMEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aBMEstudiantesToolStripMenuItem.Text = "ABM Estudiantes";
            // 
            // aBMMáquinasToolStripMenuItem
            // 
            this.aBMMáquinasToolStripMenuItem.Name = "aBMMáquinasToolStripMenuItem";
            this.aBMMáquinasToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aBMMáquinasToolStripMenuItem.Text = "ABM Máquinas";
            // 
            // aBMTrabajosToolStripMenuItem
            // 
            this.aBMTrabajosToolStripMenuItem.Name = "aBMTrabajosToolStripMenuItem";
            this.aBMTrabajosToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aBMTrabajosToolStripMenuItem.Text = "ABM Trabajos";
            // 
            // aBMMantenimientoToolStripMenuItem
            // 
            this.aBMMantenimientoToolStripMenuItem.Name = "aBMMantenimientoToolStripMenuItem";
            this.aBMMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aBMMantenimientoToolStripMenuItem.Text = "ABM Mantenimiento";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listado1ToolStripMenuItem,
            this.listado2ToolStripMenuItem,
            this.listado3ToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // listado1ToolStripMenuItem
            // 
            this.listado1ToolStripMenuItem.Name = "listado1ToolStripMenuItem";
            this.listado1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listado1ToolStripMenuItem.Text = "Listado 1";
            // 
            // listado2ToolStripMenuItem
            // 
            this.listado2ToolStripMenuItem.Name = "listado2ToolStripMenuItem";
            this.listado2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listado2ToolStripMenuItem.Text = "Listado 2";
            // 
            // listado3ToolStripMenuItem
            // 
            this.listado3ToolStripMenuItem.Name = "listado3ToolStripMenuItem";
            this.listado3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listado3ToolStripMenuItem.Text = "Listado 3";
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadística1ToolStripMenuItem,
            this.estadística2ToolStripMenuItem,
            this.estadística3ToolStripMenuItem});
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // estadística1ToolStripMenuItem
            // 
            this.estadística1ToolStripMenuItem.Name = "estadística1ToolStripMenuItem";
            this.estadística1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estadística1ToolStripMenuItem.Text = "Estadística 1";
            // 
            // estadística2ToolStripMenuItem
            // 
            this.estadística2ToolStripMenuItem.Name = "estadística2ToolStripMenuItem";
            this.estadística2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estadística2ToolStripMenuItem.Text = "Estadística 2";
            // 
            // estadística3ToolStripMenuItem
            // 
            this.estadística3ToolStripMenuItem.Name = "estadística3ToolStripMenuItem";
            this.estadística3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estadística3ToolStripMenuItem.Text = "Estadística 3";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proceso1ToolStripMenuItem,
            this.proceso2ToolStripMenuItem,
            this.proceso3ToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // proceso1ToolStripMenuItem
            // 
            this.proceso1ToolStripMenuItem.Name = "proceso1ToolStripMenuItem";
            this.proceso1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proceso1ToolStripMenuItem.Text = "Proceso 1";
            // 
            // proceso2ToolStripMenuItem
            // 
            this.proceso2ToolStripMenuItem.Name = "proceso2ToolStripMenuItem";
            this.proceso2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proceso2ToolStripMenuItem.Text = "Proceso 2";
            // 
            // proceso3ToolStripMenuItem
            // 
            this.proceso3ToolStripMenuItem.Name = "proceso3ToolStripMenuItem";
            this.proceso3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.proceso3ToolStripMenuItem.Text = "Proceso 3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(84)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFechaHora);
            this.Controls.Add(this.lblUsIngresado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsIngresado;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer fechaHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sistemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aMBAulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMáquinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMTrabajosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listado1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listado2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listado3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadística1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadística2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadística3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceso1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceso2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proceso3ToolStripMenuItem;
    }
}