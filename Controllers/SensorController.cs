using API_SensorUltrasonico.Conexion;
using API_SensorUltrasonico.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_SensorUltrasonico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController: ControllerBase
    {
        [HttpGet]
        [Route("MostrarDatosSensor")]
        public IActionResult MostrarDatosSensor(int idUsuario)
        {
            RespuestaModelo respuesta = new RespuestaModelo();
            using (SensorUltrasonicoContext db = new SensorUltrasonicoContext())
            {                
                try
                {
                    var datosRegistro = db.Sensors
                    .Where(x => x.IdUsuario == idUsuario)
                    .OrderByDescending(x => x.Fecha)
                    .ToList();

                    respuesta.Estado = "Ok";
                    respuesta.Contenido = datosRegistro;
                    return Ok(respuesta);
                }
                catch (Exception ex)
                {
                    respuesta.Estado = "error";
                    respuesta.Error = ex.Message;
                    return BadRequest(respuesta);
                }
            }            
        }

        [HttpPost]
        [Route("RegistrarDatosSensor")]
        public IActionResult RegistrarDatosSensor(SensorModelo parametros)
        {            
            using (SensorUltrasonicoContext db = new SensorUltrasonicoContext())
            {
                RespuestaModelo respuesta = new RespuestaModelo();                

                try
                {
                    Sensor datosRegistro = new Sensor
                    {
                        Fecha = DateTime.Now,
                        Sensor1 = parametros.Sensor,
                        IdUsuario = parametros.IdUsuario
                    };

                    db.Sensors.Add(datosRegistro);
                    db.SaveChanges();

                    respuesta.Estado = "Ok";
                    return Ok(respuesta);
                }
                catch (Exception ex)
                {
                    respuesta.Estado = "error";
                    respuesta.Error = ex.Message;
                    return BadRequest(respuesta);
                }
            }            
        }
    }
}

