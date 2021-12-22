using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
  class Helicpter : IAircraft
  {
    public void CheckWind()
    {
      Console.WriteLine("Verificando os ventos, ventos sudoeste ok");
    }

    public void GetCargo()
    {
      Console.WriteLine("Passageiros Ligando as Helices");
    }

    public void StartRoute()
    {
      CheckWind();
      GetCargo();
      Console.WriteLine("Iniciando decolagem");
    }
  }
}
