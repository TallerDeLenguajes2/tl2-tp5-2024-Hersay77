using EspacioPresupuestos;
using Microsoft.Data.Sqlite;

namespace EspacioPresupuestoRepository
{
    public class PresupuestoRepository
    {
        public void CrearPresupuesto(Presupuesto presupuesto)
        {

        }

        public List<Presupuesto> ListarPresupuestos()
        {
            var lista = new List<Presupuesto>();
            return lista;
        }

        public Presupuesto ObtenerDetalles(int id)
        {
            var presupuesto = new Presupuesto();

            return presupuesto;
        }

        public void AgregarProductoYCantidad(int id)
        {

        }

        public void EliminarPresupuesto(int id)
        {

        }
    }
}