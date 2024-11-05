using Microsoft.Data.Sqlite;
using EspacioProductos;

namespace EspacioProductoRepository
{
    public class ProductoRepository
    {
        public void CrearProducto(Producto producto)
        {
            
        }

        public void ModificarProducto(int idProducto, Producto producto)
        {

        }

        public List<Producto> ObtenerProductos()
        {
            var lista = new List<Producto>();

            return lista;
        }

        public Producto ObtenerProducto(int idProducto)
        {
            var producto = new Producto();

            return producto;
        }

        public void EliminarProducto(int id)
        {

        }
    }
}