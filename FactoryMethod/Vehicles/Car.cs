﻿using System;

namespace FactoryMethod.Vehicles
{
  class Car : IVehicle
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