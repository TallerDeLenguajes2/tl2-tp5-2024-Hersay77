using EspacioPresupuestos;
using Microsoft.Data.Sqlite;

namespace EspacioPresupuestoRepository
{
    public class PresupuestoRepository
    {
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