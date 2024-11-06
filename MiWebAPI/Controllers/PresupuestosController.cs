using EspacioPresupuestoRepository;

using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class PresupuestosController : ControllerBase
{
    private PresupuestoRepository presupuestoRepository;

    public PresupuestosController()
    {
        presupuestoRepository = new PresupuestoRepository("Data Source=db/Tienda.db;Cache=Shared"); //Instancia de repositorio producto, envio la cadena de conexion
    }

}











/*POST /api/Presupuesto: Permite crear un Presupuesto.
● POST /api/Presupuesto/{id}/ProductoDetalle: Permite agregar un Producto existente
y una cantidad al presupuesto.
● GET /api/presupuesto: Permite listar los presupuestos existentes.
● GET /api/Presupuesto/{id}: Permite agregar un Producto existente y una cantidad al
presupuesto.
*/