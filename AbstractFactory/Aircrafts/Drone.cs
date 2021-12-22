using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
  class Drone : IAircraft
  {
    public void CheckWind()
    {
      Console.WriteLine("Checkando bateria do drone");
    }

    public void GetCargo()
    {
      Console.WriteLine("Pegamos a encomanda de drone");
    }

    public void StartRoute()
    {
      GetCargo();
      Console.WriteLine("Inciamos a entrega de drone");
    }
  }
}
