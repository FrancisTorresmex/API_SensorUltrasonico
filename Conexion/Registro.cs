using System;
using System.Collections.Generic;

namespace API_SensorUltrasonico.Conexion
{
    public partial class Registro
    {
        public Registro()
        {
            Sensors = new HashSet<Sensor>();
        }

        public int IdUsuario { get; set; }
        public string Nombre { get; set; } = null!;
        public int Edad { get; set; }
        public string Correo { get; set; } = null!;

        public virtual ICollection<Sensor> Sensors { get; set; }
    }
}
