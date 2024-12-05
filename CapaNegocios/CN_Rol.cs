using CapaDato;
using CapaEntida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using CapaEntida;

namespace CapaNegocios
{
    public class CN_Rol
    {
        private CD_Rol objcd_rol = new CD_Rol();
        public List<ROL> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
    
