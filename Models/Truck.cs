namespace TruckPool.Models;

public class Truck
{
    public Guid TruckId { get; set; }
    public string Plate { get; set; } = "";
    public string Capacity { get; set; } = "";
    public string Measures { get; set; } = "";
}