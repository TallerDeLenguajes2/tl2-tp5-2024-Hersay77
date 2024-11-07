using EspacioPresupuestos;
using Microsoft.Data.Sqlite;
using EspacioIPresupuestoRepository;
using EspacioProductoRepository;

namespace EspacioPresupuestoRepository
{
    public class PresupuestoRepository : IPresupuestosRepository
    {
        private string cadenaDeConexion;
        public PresupuestoRepository(string cadenaDeConexion) //constructor del repositorio recibe la cadena de conexion
        {
            this.cadenaDeConexion = cadenaDeConexion;
        }
        public bool CrearPresupuesto(Presupuesto presupuesto)
        {
            //control que los productos en lista de presupuestos detalles existan
            ProductoRepository productoRepository = new ProductoRepository(cadenaDeConexion);

            foreach (var detalle in presupuesto.Detalle)
            {
                if (productoRepository.ObtenerProducto(detalle.Producto.IdProducto) == null) return false; //usando el repositorio producto intento obtener un producto con el mismo id, si no encuentra devuelve null por lo tanto no se puede realizar el presupuesto de un proudtco que no exsta
            }
            //si todos los producto en la lista presupuesto detalle existen se continua creando el presupuesto

            string query1 = @"INSERT INTO Presupuestos (NombreDestinatario, FechaCreacion) VALUES (@NombreDestinatario, @FechaCreacion)"; //consulta para tabla presupuesto, idPresupuesto es una primarykey autoincremental
            string query2 = @"INSERT INTO PresupuestosDetalle (idPresupuesto, idProducto, Cantidad) VALUES (@idPresupuesto, @idProducto, @Cantidad)";//consulta para tabla detallepresupuesto


            using (SqliteConnection connection = new SqliteConnection(cadenaDeConexion)) //creo conexion
            {
                connection.Open(); //abro conexion

                SqliteCommand command = new SqliteCommand(query1, connection); //comando con la consulta y conexion
                command.Parameters.AddWithValue("@NombreDestinatario", presupuesto.NombreDestinatario);
                command.Parameters.AddWithValue("@FechaCreacion", presupuesto.FechaCreacion);
                command.ExecuteNonQuery(); //ejecuto el comando

                long idPresupuesto;
                string queryUltimoIdCreado = "SELECT last_insert_rowid();"; //consulta para obtener ultimo id
                using (command = new SqliteCommand(queryUltimoIdCreado, connection))
                {
                    idPresupuesto = (long)command.ExecuteScalar(); //executeEscalar devuelve el valor solicitado, en el comando anterior ya se guardo un registro por lo que la tabla siempre tendra uno y no devolvera nunca null, permitiendo guardarlo en la tabla presupuestodetalle
                }
                SqliteCommand command2 = new SqliteCommand(query2, connection); //comando con la consulta y conexion
                foreach (var detalle in presupuesto.Detalle)
                {
                    
                    command2.Parameters.AddWithValue("@idPresupuesto", idPresupuesto);
                    command2.Parameters.AddWithValue("@idProducto", detalle.Producto.IdProducto);
                    command2.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                    command2.ExecuteNonQuery();
                }
                connection.Close(); //cierro conexion
            }
            return true;
        }

        public List<Presupuesto> ObtenerPresupuestos()
        {
            var lista = new List<Presupuesto>();
            return lista;
        }

        public Presupuesto ObtenerPresupuesto(int id)
        {
            var presupuesto = new Presupuesto();

            return presupuesto;
        }

        public bool AgregarProductoYCantidad(int idPresupuesto, int idProducto, int cantidad)
        {
            return true;
        }

        public void EliminarPresupuesto(int idPresupuesto)
        {

        }
    }
}