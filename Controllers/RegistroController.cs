using API_SensorUltrasonico.Models;
using Microsoft.AspNetCore.Mvc;



namespace API_SensorUltrasonico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {                 
        [HttpGet("{id}")]
        public IActionResult MostrarUsuario(RegistroModelo parametros)
        {
            RespuestaModelo respuesta = new RespuestaModelo();
            try
            {
                respuesta.Estado = "Ok";
                respuesta.Contenido = parametros;
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.Error = ex.Message;
                respuesta.Estado = "error";
                return BadRequest(respuesta);
            }
        }

        [HttpPut("{id}")]
        public IActionResult RegistroUsuario(RegistroModelo parametros)
        {
            RespuestaModelo respuesta = new RespuestaModelo();
            try
            {
                respuesta.Estado = "Ok";                
                return Ok();
            }
            catch (Exception ex)
            {
                respuesta.Error = ex.Message;
                respuesta.Estado = "error";
                return BadRequest(respuesta);
            }            
        }


    }
}
