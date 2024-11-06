using EspacioProductoRepository;
using EspacioProductos;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private ProductoRepository productoRepository;

    public ProductoController()
    {
        productoRepository = new ProductoRepository("Data Source=db/Tienda.db;Cache=Shared"); //Instancia de repositorio producto, envio la cadena de conexion
    }

    [HttpPost("api/Producto")]
    public ActionResult<Producto> CrearProducto(Producto producto)
    {
        productoRepository.CrearProducto(producto);
        return Created();
    }

    [HttpGet("api/Producto")]
    public ActionResult<List<Producto>> ObtenerProductos()
    {
        return Ok(productoRepository.ObtenerProductos());
    }

    [HttpPut("api/Producto/{Id}")]
    public ActionResult<List<Producto>> ObtenerProductos(int Id, Producto producto)
    {
        productoRepository.ModificarProducto(Id, producto);
        return Ok();
    }

    [HttpGet("api/Producto/ObtenerProducto/{Id}")]
    public ActionResult<Producto> ObtenerProducto(int Id)
    {
        Producto productoEncontrado = productoRepository.ObtenerProducto(Id);
        if (productoEncontrado == null)
        {
            return NotFound(); // No se encontro el producto
        }
        return Ok(productoEncontrado);
    }

    [HttpGet("api/Producto/EliminarProducto/{Id}")]
    public ActionResult EliinarProducto(int Id)
    {
        Producto productoEncontrado = productoRepository.ObtenerProducto(Id);
        if (productoEncontrado == null)
        {
            return NotFound(); // No se encontro el producto
        }
        productoRepository.EliminarProducto(Id); // Eliminación
        return NoContent();
    }

}