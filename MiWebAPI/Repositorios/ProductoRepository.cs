using Microsoft.Data.Sqlite;
using EspacioProductos;

namespace EspacioProductoRepository
{
    public class EspacioProductoRepository
    {

        public void CrearProducto(Producto producto)
        {
            
        }

        public void ModificarProducto(int Id, Producto producto)
        {

        }

        public List<Producto> ListarProductos()
        {
            var lista = new List<Producto>();

            return lista;
        }

        public Producto ObtenerDetalle(int id)
        {
            var producto = new Producto();

            return producto;
        }

        public void EliminarProducto(int id)
        {

        }
    }
}