using System.ComponentModel.DataAnnotations;
namespace EvaluacionFinal1.Models
{
    public class Vehiculos
    {
        [Required]
        public int NumChasis { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public int AnioFabricacion { get; set; }
     
    }
}
