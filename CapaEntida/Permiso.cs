using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntida
{
    public class Permiso
    {
        public int IdPermiso { get; set; }
        public ROL oROL { get; set; }
        public string NombreMenu { get; set; }
        public string FechaRegistro { get; set; }
    }
}
