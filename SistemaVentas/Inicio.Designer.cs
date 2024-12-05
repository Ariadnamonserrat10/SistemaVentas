namespace SistemaVentas
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.MenuMantenimiento = new FontAwesome.Sharp.IconMenuItem();
            this.SubMCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.SubMProducto = new FontAwesome.Sharp.IconMenuItem();
            this.MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.SubMregistrarV = new FontAwesome.Sharp.IconMenuItem();
            this.VerDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.MenuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.SubMRegistrarC = new FontAwesome.Sharp.IconMenuItem();
            this.SubMVDCom = new FontAwesome.Sharp.IconMenuItem();
            this.MenuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.MenuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.MenuAcercaDe = new FontAwesome.Sharp.IconMenuItem();
            this.MenuTitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LBLUsuario = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.White;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUsuario,
            this.MenuMantenimiento,
            this.MenuVentas,
            this.MenuCompras,
            this.MenuClientes,
            this.MenuProveedores,
            this.MenuReportes,
            this.MenuAcercaDe});
            this.Menu.Location = new System.Drawing.Point(0, 57);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1184, 73);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.AutoSize = false;
            this.MenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.MenuUsuario.IconColor = System.Drawing.Color.Black;
            this.MenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuUsuario.IconSize = 50;
            this.MenuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(122, 69);
            this.MenuUsuario.Text = "Usuarios";
            this.MenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuUsuario.Click += new System.EventHandler(this.MenuUsuario_Click);
            // 
            // MenuMantenimiento
            // 
            this.MenuMantenimiento.AutoSize = false;
            this.MenuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMCategoria,
            this.SubMProducto});
            this.MenuMantenimiento.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.MenuMantenimiento.IconColor = System.Drawing.Color.Black;
            this.MenuMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuMantenimiento.IconSize = 50;
            this.MenuMantenimiento.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuMantenimiento.Name = "MenuMantenimiento";
            this.MenuMantenimiento.Size = new System.Drawing.Size(122, 69);
            this.MenuMantenimiento.Text = "Mantenimiento";
            this.MenuMantenimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // SubMCategoria
            // 
            this.SubMCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMCategoria.IconColor = System.Drawing.Color.Black;
            this.SubMCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMCategoria.Name = "SubMCategoria";
            this.SubMCategoria.Size = new System.Drawing.Size(125, 22);
            this.SubMCategoria.Text = "Categoria";
            this.SubMCategoria.Click += new System.EventHandler(this.SubMCategoria_Click);
            // 
            // SubMProducto
            // 
            this.SubMProducto.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMProducto.IconColor = System.Drawing.Color.Black;
            this.SubMProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMProducto.Name = "SubMProducto";
            this.SubMProducto.Size = new System.Drawing.Size(125, 22);
            this.SubMProducto.Text = "Producto";
            this.SubMProducto.Click += new System.EventHandler(this.SubMProducto_Click);
            // 
            // MenuVentas
            // 
            this.MenuVentas.AutoSize = false;
            this.MenuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMregistrarV,
            this.VerDetalleVenta});
            this.MenuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.MenuVentas.IconColor = System.Drawing.Color.Black;
            this.MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuVentas.IconSize = 50;
            this.MenuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVentas.Name = "MenuVentas";
            this.MenuVentas.Size = new System.Drawing.Size(122, 69);
            this.MenuVentas.Text = "Ventas";
            this.MenuVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuVentas.Click += new System.EventHandler(this.MenuVentas_Click);
            // 
            // SubMregistrarV
            // 
            this.SubMregistrarV.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMregistrarV.IconColor = System.Drawing.Color.Black;
            this.SubMregistrarV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMregistrarV.Name = "SubMregistrarV";
            this.SubMregistrarV.Size = new System.Drawing.Size(180, 22);
            this.SubMregistrarV.Text = "Registrar";
            this.SubMregistrarV.Click += new System.EventHandler(this.SubMregistrarV_Click);
            // 
            // VerDetalleVenta
            // 
            this.VerDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.None;
            this.VerDetalleVenta.IconColor = System.Drawing.Color.Black;
            this.VerDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VerDetalleVenta.Name = "VerDetalleVenta";
            this.VerDetalleVenta.Size = new System.Drawing.Size(180, 22);
            this.VerDetalleVenta.Text = "Ver Detalle";
            this.VerDetalleVenta.Click += new System.EventHandler(this.VerDetalleVenta_Click);
            // 
            // MenuCompras
            // 
            this.MenuCompras.AutoSize = false;
            this.MenuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubMRegistrarC,
            this.SubMVDCom});
            this.MenuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.MenuCompras.IconColor = System.Drawing.Color.Black;
            this.MenuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuCompras.IconSize = 50;
            this.MenuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuCompras.Name = "MenuCompras";
            this.MenuCompras.Size = new System.Drawing.Size(122, 69);
            this.MenuCompras.Text = "Compras";
            this.MenuCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuCompras.Click += new System.EventHandler(this.iconMenuItem8_Click);
            // 
            // SubMRegistrarC
            // 
            this.SubMRegistrarC.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMRegistrarC.IconColor = System.Drawing.Color.Black;
            this.SubMRegistrarC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMRegistrarC.Name = "SubMRegistrarC";
            this.SubMRegistrarC.Size = new System.Drawing.Size(129, 22);
            this.SubMRegistrarC.Text = "Registrar";
            this.SubMRegistrarC.Click += new System.EventHandler(this.SubMRegistrarC_Click);
            // 
            // SubMVDCom
            // 
            this.SubMVDCom.IconChar = FontAwesome.Sharp.IconChar.None;
            this.SubMVDCom.IconColor = System.Drawing.Color.Black;
            this.SubMVDCom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SubMVDCom.Name = "SubMVDCom";
            this.SubMVDCom.Size = new System.Drawing.Size(129, 22);
            this.SubMVDCom.Text = "Ver Detalle";
            this.SubMVDCom.Click += new System.EventHandler(this.SubMVDCom_Click);
            // 
            // MenuClientes
            // 
            this.MenuClientes.AutoSize = false;
            this.MenuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.MenuClientes.IconColor = System.Drawing.Color.Black;
            this.MenuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuClientes.IconSize = 50;
            this.MenuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuClientes.Name = "MenuClientes";
            this.MenuClientes.Size = new System.Drawing.Size(122, 69);
            this.MenuClientes.Text = "Clientes";
            this.MenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuProveedores
            // 
            this.MenuProveedores.AutoSize = false;
            this.MenuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.MenuProveedores.IconColor = System.Drawing.Color.Black;
            this.MenuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuProveedores.IconSize = 50;
            this.MenuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProveedores.Name = "MenuProveedores";
            this.MenuProveedores.Size = new System.Drawing.Size(122, 69);
            this.MenuProveedores.Text = "Proveedores";
            this.MenuProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuReportes
            // 
            this.MenuReportes.AutoSize = false;
            this.MenuReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.MenuReportes.IconColor = System.Drawing.Color.Black;
            this.MenuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuReportes.IconSize = 50;
            this.MenuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(122, 69);
            this.MenuReportes.Text = "Reportes";
            this.MenuReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MenuReportes.Click += new System.EventHandler(this.MenuReportes_Click);
            // 
            // MenuAcercaDe
            // 
            this.MenuAcercaDe.AutoSize = false;
            this.MenuAcercaDe.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.MenuAcercaDe.IconColor = System.Drawing.Color.Black;
            this.MenuAcercaDe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuAcercaDe.IconSize = 50;
            this.MenuAcercaDe.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuAcercaDe.Name = "MenuAcercaDe";
            this.MenuAcercaDe.Size = new System.Drawing.Size(122, 69);
            this.MenuAcercaDe.Text = "Acerca De";
            this.MenuAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // MenuTitulo
            // 
            this.MenuTitulo.AutoSize = false;
            this.MenuTitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.MenuTitulo.Location = new System.Drawing.Point(0, 0);
            this.MenuTitulo.Name = "MenuTitulo";
            this.MenuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuTitulo.Size = new System.Drawing.Size(1184, 57);
            this.MenuTitulo.TabIndex = 1;
            this.MenuTitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistemas Ventas";
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 130);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1184, 471);
            this.Contenedor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(749, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario : ";
            // 
            // LBLUsuario
            // 
            this.LBLUsuario.AutoSize = true;
            this.LBLUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.LBLUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUsuario.ForeColor = System.Drawing.Color.White;
            this.LBLUsuario.Location = new System.Drawing.Point(814, 20);
            this.LBLUsuario.Name = "LBLUsuario";
            this.LBLUsuario.Size = new System.Drawing.Size(82, 15);
            this.LBLUsuario.TabIndex = 5;
            this.LBLUsuario.Text = "LBLUsuario";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 601);
            this.Controls.Add(this.LBLUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.MenuTitulo);
            this.MainMenuStrip = this.Menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.MenuStrip MenuTitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem MenuProveedores;
        private FontAwesome.Sharp.IconMenuItem MenuUsuario;
        private FontAwesome.Sharp.IconMenuItem MenuMantenimiento;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuCompras;
        private FontAwesome.Sharp.IconMenuItem MenuClientes;
        private FontAwesome.Sharp.IconMenuItem MenuReportes;
        private FontAwesome.Sharp.IconMenuItem MenuAcercaDe;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBLUsuario;
        private FontAwesome.Sharp.IconMenuItem SubMCategoria;
        private FontAwesome.Sharp.IconMenuItem SubMProducto;
        private FontAwesome.Sharp.IconMenuItem SubMregistrarV;
        private FontAwesome.Sharp.IconMenuItem VerDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem SubMRegistrarC;
        private FontAwesome.Sharp.IconMenuItem SubMVDCom;
    }
}

