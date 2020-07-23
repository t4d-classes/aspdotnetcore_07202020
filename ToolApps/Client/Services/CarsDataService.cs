using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolApps.Shared.Models;

namespace ToolApps.Client.Services
{
  public class CarsDataService
  {
    private List<Car> _cars;

    public CarsDataService()
    {
      _cars = new List<Car>();
      _cars.Add(new Car() { Id = 1, Make = "Mazda", Model = "Miata", Year = 2018, Color ="red", Price = 50000 });
      _cars.Add(new Car() { Id = 2, Make = "Ford", Model = "Fusion Hybrid", Year = 2018, Color = "blue", Price = 45000 });
    
      Console.WriteLine("creating cars data service");  
    }

    public IEnumerable<Car> All()
    {
      return _cars;
    }
  }
}
