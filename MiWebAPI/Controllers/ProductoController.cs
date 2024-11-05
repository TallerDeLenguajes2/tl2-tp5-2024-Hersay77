using EspacioProductoRepository;
using EspacioProductos;
using Microsoft.AspNetCore.Mvc;
namespace tl2_tp5_2024_Hersay77.Controller;

[ApiController]
[Route("[controller]")]
public class ProductoController : ControllerBase
{
    private ProductoRepository productoRepository;

    public ProductoController()
    {
        productoRepository = new ProductoRepository("Data Source=db/Tienda.db;Cache=Shared"); //Instancia de repositorio producto, envio la cadena de conexion
    }

    [HttpPost("/api/Producto")]
    public ActionResult<Producto> CrearProducto(Producto producto) 
    {
        productoRepository.CrearProducto(producto);
        return Created();
    }

}