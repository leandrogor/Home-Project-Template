using PlantillaInicioProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlantillaInicioProyecto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            boxUsuario.Text = "";
            boxContrasenia.Text = "";
        }

        private bool noEstanVacios(string campo1, string campo2)
        {
            if (campo1.Equals("") || campo2.Equals(""))
            {
                return false;
            }
            return true;
        }

        private bool esUsuarioCorrecto(string usuCargado, string usuCorrecto, string conCargado, string conCorrecta)
        {
            if (usuCargado == usuCorrecto && conCargado == conCorrecta)
            {
                return true;
            }
            return false;
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            string usuarioCargado = boxUsuario.Text.Trim();
            string contraCargada = boxContrasenia.Text.Trim();

            if (noEstanVacios(usuarioCargado, contraCargada))
            {
                string usuario = System.Configuration.ConfigurationManager.AppSettings["User"];
                string contra = System.Configuration.ConfigurationManager.AppSettings["Pass"];

                if (esUsuarioCorrecto(usuarioCargado, usuario, contraCargada, contra))
                {
                    MessageBox.Show("Datos validados, bienvenido al sistema!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Usuario usu = new Usuario(usuarioCargado, contraCargada);
                    MainForm ventana = new MainForm(usu);
                    Hide();
                    ventana.Show();

                }
                else
                {
                    DialogResult res = MessageBox.Show("Datos incorrectos!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (res == DialogResult.Cancel)
                    {
                        LimpiarCampos();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Por favor, ingrese todos los campos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}