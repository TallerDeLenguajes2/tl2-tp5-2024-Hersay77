using EspacioProductos;

namespace EspacioPresupuestosDetalle
{
    public class PresupuestosDetalle
    {
        private Producto producto;
        private int cantidad;
        public Producto Producto { get => producto; set => producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}