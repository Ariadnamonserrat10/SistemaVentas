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
            String mensaje = string.Empty;
            Usuario objusuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtID.Text),
                Documento = txtDoc.Text,
                NombreCompleto = txtNCompleto.Text,
                Correo = txtCorreo.Text,
                Clave = txtClave.Text,
                oROL = new ROL() { IdRol = Convert.ToInt32(((OpcionCombo)CboRol.SelectedItem).Valor) },
                Estado = Convert.ToInt32(((OpcionCombo)CBoEstado.SelectedItem).Valor) == 1 ? true : false
            };
            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvdata.Rows.Add(new object[] {"",idusuariogenerado,txtDoc.Text,txtNCompleto.Text,txtCorreo.Text,txtClave.Text,
                ((OpcionCombo)CboRol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CboRol.SelectedItem).Texto.ToString(),
                ((OpcionCombo)CBoEstado.SelectedItem).Valor.ToString(),
                ((OpcionCombo)CBoEstado.SelectedItem).Texto.ToString()});
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvdata.Rows[Convert.ToInt32(txtindice.Text)];
                    row.Cells["Id"].Value = txtID.Text;
                    row.Cells["Documento"].Value = txtDoc.Text;
                    row.Cells["Nombrecompleto"].Value = txtNCompleto.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)CboRol.SelectedItem).Valor.ToString();
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }


            }


        }
        private void Limpiar()
        {
            txtindice.Text = "-1";
            txtID.Text = "0";
            txtDoc.Text = "";
            txtNCompleto.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtCClave.Text = "";
            CboRol.SelectedIndex = 0;
            CBoEstado.SelectedIndex = 0;

            txtDoc.Select();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CBoEstado.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            CBoEstado.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            CBoEstado.DisplayMember = "Texto";
            CBoEstado.ValueMember = "Valor";
            CBoEstado.SelectedIndex = 0;

            List<ROL> listaRol = new CN_Rol().Listar();
            foreach (ROL item in listaRol)
            {
                CboRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Descripcion });
            }
            CboRol.DisplayMember = "Texto";
            CboRol.ValueMember = "Valor";
            CboRol.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvdata.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnseleccionar")
                {
                    cboBusqueda.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });

                }
            }

            cboBusqueda.DisplayMember = "Texto";
            cboBusqueda.ValueMember = "Valor";
            cboBusqueda.SelectedIndex = 0;

            //mostrar todos los usuarios 

            List<Usuario> listausuario = new CN_Usuario().Listar();
            foreach (Usuario item in listausuario)
            {
                dgvdata.Rows.Add(new object[] {"",item.IdUsuario,item.Documento,item.NombreCompleto,item.Correo,item.Clave,
               item.oROL.IdRol,
                item.oROL.Descripcion,
               item.Estado == true ? 1 : 0,
                item.Estado == true ? "Activo" :"No Activo"});
            }



        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;

            }

            {

            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvdata.Columns[e.ColumnIndex].Name == "btnseleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    txtID.Text = dgvdata.Rows[indice].Cells["id"].Value.ToString();
                    txtDoc.Text = dgvdata.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNCompleto.Text = dgvdata.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvdata.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();
                    txtCClave.Text = dgvdata.Rows[indice].Cells["Clave"].Value.ToString();

                    foreach (OpcionCombo oc in CboRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indice_Combo = CboRol.Items.IndexOf(oc);
                            CboRol.SelectedIndex = indice_Combo;
                            break;
                        }
                    }

                    foreach (OpcionCombo oc in CBoEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvdata.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_Combo = CBoEstado.Items.IndexOf(oc);
                            CBoEstado.SelectedIndex = indice_Combo;
                            break;

                        }
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtID.Text) != 0)
            {
                if (MessageBox.Show("Desea Eliminar el usuario", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtID.Text),
                    };
                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);
                    if (respuesta)
                    {
                        dgvdata.Rows.RemoveAt(Convert.ToInt32(txtindice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
