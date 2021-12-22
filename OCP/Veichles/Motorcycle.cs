﻿using System;

namespace OCP.Veichle
{
  public class Motorcycle : Vehicle
  {
    public Motorcycle(string color, int year, double engine) : base(color, year, engine)
    {
      ConfigureMotorcycle();
    }

    public void ConfigureMotorcycle()
    {
      Console.WriteLine($"Criando uma Moto {color}, { year}, { engine} cilindrada. ");
      StartVehicle();
    }
  }
}
