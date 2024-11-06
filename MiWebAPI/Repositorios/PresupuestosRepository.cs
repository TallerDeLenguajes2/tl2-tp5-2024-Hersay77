using EspacioPresupuestos;
using Microsoft.Data.Sqlite;
using EspacioIPresupuestoRepository;

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