using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
  class Car : ILandVehicle
  {
    public void GetCargo()
    {
      Console.WriteLine("Pegamos os passageiros");
    }

    public void StartRoute()
    {
      GetCargo();
      Console.WriteLine("Inciamos o trajeto");
    }
  }
}
