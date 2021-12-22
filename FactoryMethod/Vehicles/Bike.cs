using System;

namespace FactoryMethod.Vehicles
{
  class Bike : IVehicle
  {
    public void GetCargo()
    {
      Console.WriteLine("Pegamos seu lanche bike!");
    }

    public void StartRoute()
    {
      GetCargo();
      Console.WriteLine("Iniciamos a entrega do seu lanche bike!");
    }
  }
}
