using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
  class Patinete : ILandVehicle
  {
    public void GetCargo()
    {
      Console.WriteLine("Pegamos a encomanda de patinete");
    }

    public void StartRoute()
    {
      GetCargo();
      Console.WriteLine("Inciamos a entrega de patinete");
    }
  }
}
