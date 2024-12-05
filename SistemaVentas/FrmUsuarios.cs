using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentas.Utilidades;
using CapaEntida;
using CapaNegocios;

namespace SistemaVentas
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CBoEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBoEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CBoEstado.DisplayMember= "Texto";
            CBoEstado.ValueMember= "Valor";
            CBoEstado.SelectedIndex= 0;

            List<ROL> listaRol = new CN_Rol().Listar();
            foreach (ROL item in listaRol)
            {
                CboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            CboRol.DisplayMember = "Texto";
            CboRol.ValueMember = "Valor";
            CboRol.SelectedIndex = 0;

        }
    }
}
