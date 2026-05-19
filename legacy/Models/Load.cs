namespace TruckPool.Models;
using System.ComponentModel.DataAnnotations;

public class Load
{
    public Guid LoadId { get; set; }

    [Required(ErrorMessage = "El paquete es obligatorio")]
    public string Package { get; set; } = "";

    [Required(ErrorMessage = "El origen es obligatorio")]
    public string Origin { get; set; } = "";

    [Required(ErrorMessage = "El destino es obligatorio")]
    public string Destiny { get; set; } = "";

    [Required(ErrorMessage = "Las medidas son obligatorias")]
    public string Measures { get; set; } = "";

    [Required(ErrorMessage = "La fecha es obligatoria")]
    public DateTime Date { get; set; }
    public string Status { get; set; } = "";
}