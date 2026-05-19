// namespace TruckPool.Data;

// using TruckPool.Models;

// public static class DemoData
// {
//     public static List<User> Users = new()
//     {
//         new User { Name="Juan Pérez", Email="juan@example.com" },
//         new User { Name="Ana Torres", Email="ana@example.com" },
//         new User { Name="Carlos Gómez", Email="carlos@example.com" }
//     };

//     public static List<Driver> Truckers = new()
//     {
//         new Driver { Name="Diego Díaz", Location="CABA", Role=Fletero },
//         new Driver { Name="Fernando Ruiz", Location="La Plata", Role=Dueño de flota }
//     };

//     public static List<Load> Envíos = new()
//     {
//         new Load {
//             LoadId = Guid.NewGuid(),
//             Package = "Heladera",
//             Origin = "CABA",
//             Destiny = "La Plata",
//             Measures = "120x60x60",
//             Date = DateTime.Today.AddDays(1),
//             Status = "En progreso"
//         },
//         new Load {
//             LoadId = Guid.NewGuid(),
//             Package = "Sillón",
//             Origin = "Tigre",
//             Destiny = "CABA",
//             Measures = "200x80x80",
//             Date = DateTime.Today.AddDays(-4),
//             Status = "Entregado"
//         }
//     };
// }