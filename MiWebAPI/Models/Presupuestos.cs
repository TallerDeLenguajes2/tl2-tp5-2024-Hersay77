using EspacioPresupuestosDetalle;

namespace EspacioPresupuestos
{
    public class Presupuestos
    {
        private int IdPresupuesto;
        private string nombreDestinatario;
        private List<PresupuestosDetalle> detalle;

        public int IdPresupuesto1 { get => IdPresupuesto; set => IdPresupuesto = value; }
        public string NombreDestinatario { get => nombreDestinatario; set => nombreDestinatario = value; }
        public List<PresupuestosDetalle> Detalle { get => detalle; set => detalle = value; }

        public float MontoPresupuesto()
        {
            return 0;
        }

        public float MontoPresupuestoConIva()
        {
            return 0;
        }
        public int CantidadProductos()
        {
            return 0;
        }

    }
}