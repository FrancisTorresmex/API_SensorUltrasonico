using API_SensorUltrasonico.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_SensorUltrasonico.Controllers
{
    public class SensorController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class RegistroController : ControllerBase
        {
            [HttpGet("{id}")]
            public IActionResult MostrarDatosSensor(SensorModelo parametros)
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
                    respuesta.Estado = "error";
                    respuesta.Error = ex.Message;
                    return BadRequest(respuesta);
                }
            }

            [HttpPost("{id}")]
            public IActionResult RegistrarDatosSensor(SensorModelo parametros)
            {
                RespuestaModelo respuesta = new RespuestaModelo();
                try
                {
                    respuesta.Estado = "Ok";                
                    return Ok();
                }
                catch (Exception ex)
                {
                    respuesta.Estado= "error";
                    respuesta.Error = ex.Message;
                    return BadRequest(respuesta);
                }
            }
        }        
    }
}
