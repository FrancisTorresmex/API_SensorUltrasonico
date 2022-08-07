using API_SensorUltrasonico.Conexion;
using API_SensorUltrasonico.Models;
using Microsoft.AspNetCore.Mvc;



namespace API_SensorUltrasonico.Controllers
{
    [ApiController]
    [Route("api/[controller]")]    
    public class RegistroController : ControllerBase
    {                 
        [HttpGet]
        [Route("MostrarUsuario")]
        public IActionResult MostrarUsuario(int idUsuario)
        {
            RespuestaModelo respuesta = new RespuestaModelo();

            using (SensorUltrasonicoContext db = new SensorUltrasonicoContext())
            {                
                try
                {

                    var datosRegistro = db.Registros.Where(x => x.IdUsuario == idUsuario).ToList();
                    if (datosRegistro != null || datosRegistro.Count > 0)
                    {
                        respuesta.Estado = "Ok";
                        respuesta.Contenido = datosRegistro;
                    }
                    return Ok(respuesta);                    
                }
                
                catch (Exception ex)
                {
                    respuesta.Error = ex.Message;
                    respuesta.Estado = "error";
                    return BadRequest(respuesta);
                }                       
            }            
        }

        [HttpPut]
        [Route("RegistroUsuario")]
        public IActionResult RegistroUsuario(RegistroModelo parametros)
        {
            RespuestaModelo respuesta = new RespuestaModelo();
            using (SensorUltrasonicoContext db = new SensorUltrasonicoContext())
            {
                try
                {                    
                    var existeCorreo = db.Registros.Where(x => x.Correo == parametros.Correo).FirstOrDefault();
                    var existeTel = db.Registros.Where(x => x.Telefono == parametros.Telefono).FirstOrDefault();

                    if (existeCorreo != null) //si ya existe el correo
                    {
                        respuesta.Estado = "Ok";
                        respuesta.Error = "El correo ya existe";
                        return Ok(respuesta);
                    }
                    if (existeTel != null) //si ya existe el correo
                    {
                        respuesta.Estado = "Ok";
                        respuesta.Error = "Telefono ya registrado en una cuenta";
                        return Ok(respuesta);
                    }

                    Registro datosRegistro = new Registro
                    {
                        Correo = parametros.Correo,
                        Edad = parametros.Edad,
                        Nombre = parametros.Nombre,
                        Telefono = parametros.Telefono,
                        Mensaje = parametros.Mensaje
                    };
                    db.Registros.Add(datosRegistro);
                    db.SaveChanges();

                    respuesta.Estado = "Ok";
                    return Ok(respuesta);
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
}
