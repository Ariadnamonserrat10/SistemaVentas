using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntida
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public ROL oROL { get; set; }
        public bool Estado { get; set; }
    }
}
