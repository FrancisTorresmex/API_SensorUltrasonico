using System;
using System.Collections.Generic;

namespace API_SensorUltrasonico.ModelsUpdate
{
    public partial class Sensor
    {
        public int IdRegistro { get; set; }
        public string? Sensor1 { get; set; }
        public DateTime Fecha { get; set; }
        public int IdUsuario { get; set; }

        public virtual Registro IdUsuarioNavigation { get; set; } = null!;
    }
}
