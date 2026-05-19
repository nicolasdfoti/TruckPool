using System.ComponentModel.DataAnnotations;

namespace TruckPool.Models;

public class Driver
{
    public Guid DriverId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(80, ErrorMessage = "Máximo 80 carácteres")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "El Email es obligatorio")]
    [EmailAddress(ErrorMessage = "Máximo 80 carácteres")]
    public string Email { get; set; } = "";

    [Required(ErrorMessage = "La locación es obligatoria")]
    [StringLength(80, ErrorMessage = "Máximo 80 carácteres")]
    public string Location { get; set; } = "";

    [Required(ErrorMessage = "El rol es obligatorio")]
    public Role Role { get; set; }
}

public enum Role
{
    Fletero,
    DueñoDeCompañiaDeFletes
}