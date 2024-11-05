using Microsoft.Data.Sqlite;
using EspacioProductos;

namespace EspacioProductoRepository
{
    public class ProductoRepository : IProductoRepository
    {
        private string cadenaDeConexion;
        public ProductoRepository(string cadenaDeConexion) //constructor del repositorio recibe la cadena de conexion
        {
            this.cadenaDeConexion = cadenaDeConexion;
        }

        public void CrearProducto(Producto producto)
        {

            string queryString = @"INSERT INTO Productos (Descripcion, Precio) VALUES (@Descripcion, @Precio)"; //consulta

            using (SqliteConnection connection = new SqliteConnection(cadenaDeConexion)) //creo conexion
            {
                connection.Open(); //abro conexion
                SqliteCommand command = new SqliteCommand(queryString, connection); //comando con la consulta y conexion
                command.Parameters.AddWithValue("@Descripcion", producto.Descripcion); //parametrizo la consulta
                command.Parameters.AddWithValue("@Precio", producto.Precio);
                command.ExecuteNonQuery(); //ejecuto el comando
                connection.Close(); //cierro conexion
            }

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