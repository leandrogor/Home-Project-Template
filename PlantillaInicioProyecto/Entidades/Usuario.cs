using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaInicioProyecto.Entidades
{
    public class Usuario
    {
        public string NombreDeUsuario { get; set; }
        public string Contrasenia { get; set; }
        public bool Activo { get; set; } = true;
        public DateTime? FechaLogin { get; set; } = DateTime.Now;

        public Usuario(string NombreDeUsuario, string Contrasenia)
        {
            this.NombreDeUsuario = NombreDeUsuario;
            this.Contrasenia = Contrasenia;
        }
    }
}
