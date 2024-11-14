using System.ComponentModel.DataAnnotations;

namespace PersonasApp.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string TipoDocumento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Ingrese un valor numérico válido")]
        public decimal ValorAGanar { get; set; }

        [Required]
        public string EstadoCivil { get; set; }
    }
}

