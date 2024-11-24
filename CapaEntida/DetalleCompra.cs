using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntida
{
    public class DetalleCompra
    {
        public List<DetalleCompra> oDetalleCompras { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
