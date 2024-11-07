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

    [HttpGet("api/presupuesto/")]
    public ActionResult<List<Presupuesto>> ObtenerPresupuestos()
    {
        return Ok(presupuestoRepository.ObtenerPresupuestos());
    }

    [HttpGet("api/Presupuesto/{id}")]
    public ActionResult<Presupuesto> ObtenerPresupuesto(int id)
    {
        return Ok(presupuestoRepository.ObtenerPresupuesto(id));
    }

    [HttpPost("api/Presupuesto/{id}/ProductoDetalle")]
    public ActionResult AgregarProductoYCantidadAlPresupuesto(int id, int idProducto, int cantidad)
    {
        if (!presupuestoRepository.AgregarProductoYCantidad(id, idProducto, cantidad)) return BadRequest();
        return Created();
    }

    [HttpDelete("api/Presupuesto/{id}/EliminarPresupuesto")]
    public ActionResult EliminarPresupuesto(int id)
    {
        if (!presupuestoRepository.EliminarPresupuesto(id)) return BadRequest();
        return Ok();
    }

}











/*POST /api/Presupuesto: Permite crear un Presupuesto.
● POST /api/Presupuesto/{id}/ProductoDetalle: Permite agregar un Producto existente
y una cantidad al presupuesto.
● GET /api/presupuesto: Permite listar los presupuestos existentes.
● GET /api/Presupuesto/{id}: Permite agregar un Producto existente y una cantidad al
presupuesto.
*/