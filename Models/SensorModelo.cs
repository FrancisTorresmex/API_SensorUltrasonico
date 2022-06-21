namespace API_SensorUltrasonico.Models
{
    public class SensorModelo
    {
        public int IdRegistro { get; set; }
        public string? Sensor { get; set; }
        public DateTime Fecha { get; set; }        
        public int IdUsuario { get; set; }  
    }
}
