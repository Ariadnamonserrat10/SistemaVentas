﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SistemaVentas
{
    public partial class Inicio : Form
    {

        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario) {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null) { 

                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.SteelBlue;
            Contenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void MenuUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmUsuarios());
        }

        private void SubMCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((MenuMantenimiento), new FrmCategoria());
        }

        private void SubMProducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((MenuMantenimiento), new FrmProducto());
        }

        private void SubMregistrarV_Click(object sender, EventArgs e)
        {
            AbrirFormulario((MenuVentas), new FrmVentas());
        }

        private void VerDetalleVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((MenuVentas), new FrmDetalleV());
        }

        private void SubMRegistrarC_Click(object sender, EventArgs e)
        {
            AbrirFormulario((MenuCompras), new FrmCompras());
        }

        private void SubMVDCom_Click(object sender, EventArgs e)
        {
            AbrirFormulario((MenuCompras), new FrmDetalleC());
        }

       /* private void MenuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmClientes());
        }
       */
       /* private void MenuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmProveedores());
        }*/

        private void MenuReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FrmReportes());
        }
    }
}