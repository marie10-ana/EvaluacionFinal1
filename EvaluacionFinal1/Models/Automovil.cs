using System.ComponentModel.DataAnnotations;

namespace EvaluacionFinal1.Models
{
    public class Automovil: Vehiculos
    {
        public int NumPuertas { get; set; }
        [Required]
        public string TipoCombustible { get; set; }
    }
}
