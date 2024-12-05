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
    public class CN_Permiso
    {
        private CD_PERMISO objcd_permiso = new CD_PERMISO();
        public List<Permiso> Listar(int idUsuario)
        {
            return objcd_permiso.Listar(idUsuario);
        }
    }
}
