using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolApps.Shared.Models;

namespace ToolApps.Client.Services
{
  public class ColorsDataService
  {
    private List<Color> _colors;

    public ColorsDataService()
    {
      _colors = new List<Color>();
      _colors.Add(new Color() { Id = 1, Name = "red", Hexcode = "ff0000" });
      _colors.Add(new Color() { Id = 2, Name = "green", Hexcode = "00ff00" });
      _colors.Add(new Color() { Id = 3, Name = "blue", Hexcode = "0000ff" });
    }

    public IEnumerable<Color> All()
    {
      return _colors;
    }
  }
}
