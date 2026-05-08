namespace TruckPool.Models;

using System.ComponentModel.DataAnnotations;

public class Trip
{
    public Guid TripId { get; set; }

    [Required(ErrorMessage = "El origen es obligatorio")]
    public string Origin { get; set; } = "";

    [Required(ErrorMessage = "El destino es obligatorio")]
    public string Destiny { get; set; } = "";

    [Required(ErrorMessage = "La fecha de inicio es obligatoria")]
    public DateTime StartDate { get; set; } = DateTime.Today;
}