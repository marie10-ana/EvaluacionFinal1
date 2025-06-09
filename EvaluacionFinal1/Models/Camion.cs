using System.ComponentModel.DataAnnotations;

namespace EvaluacionFinal1.Models
{
    public class Camion:Vehiculos
    {
        [Required]
        public double Capacidad { get; set; }
        [Required]
        public int NumLlantas { get; set; }
    }
}
