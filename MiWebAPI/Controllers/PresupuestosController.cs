using EspacioPresupuestoRepository;
using EspacioPresupuestos;
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

    [HttpPost("api/Presupuesto")]
    public ActionResult CrearPresupuesto([FromBody] Presupuesto presupuesto)
    {
        if (!presupuestoRepository.CrearPresupuesto(presupuesto)) return BadRequest();
        return Created();
    }

}











/*POST /api/Presupuesto: Permite crear un Presupuesto.
● POST /api/Presupuesto/{id}/ProductoDetalle: Permite agregar un Producto existente
y una cantidad al presupuesto.
● GET /api/presupuesto: Permite listar los presupuestos existentes.
● GET /api/Presupuesto/{id}: Permite agregar un Producto existente y una cantidad al
presupuesto.
*/