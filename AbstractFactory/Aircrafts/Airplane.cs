using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
  class Airplane : IAircraft
  {
    public void CheckWind()
    {
      Console.WriteLine("Verificando os ventos, ventos 25km ok");
    }

    public void GetCargo()
    {
      Console.WriteLine("Passageiros Abordo, voo autorizado");
    }

    public void StartRoute()
    {
      CheckWind();
      GetCargo();
      Console.WriteLine("Ligando as turbinas");
    }
  }
}
