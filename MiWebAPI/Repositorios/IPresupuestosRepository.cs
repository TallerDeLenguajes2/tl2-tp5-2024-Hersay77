using EspacioPresupuestos;
namespace EspacioIPresupuestoRepository;
public interface IPresupuestosRepository
{
    public bool CrearPresupuesto(Presupuesto presupuesto);

    public List<Presupuesto> ObtenerPresupuestos();
    public Presupuesto ObtenerPresupuesto(int id);

    public bool AgregarProductoYCantidad(int idPresupuesto, int idProducto, int cantidad);
    public void EliminarPresupuesto(int idPresupuesto);

}