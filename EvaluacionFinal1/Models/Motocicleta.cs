using System.ComponentModel.DataAnnotations;

namespace EvaluacionFinal1.Models
{
    public class Motocicleta: Vehiculos
    {
        [Required]
        public int Cilindrada { get; set; }
        [Required]
        public string Tipo { get; set; }
    }
}
