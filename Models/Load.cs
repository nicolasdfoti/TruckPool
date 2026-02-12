namespace TruckPool.Models;

public class Load
{
    public Guid LoadId { get; set; }
    public string Package { get; set; } = "";
    public string Origin { get; set; } = "";
    public string Destiny { get; set; } = "";
    public string Measures { get; set; } = "";
    public DateTime Date { get; set; }
    public string Status { get; set; } = "";
}