using OCP.Veichle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
  class Program
  {
    static void Main(string[] args)
    {

      TypeVehicle type = TypeVehicle.CAR;

      if (type == TypeVehicle.CAR)
      {
        Car veihicle = new Car("Azul", 2022, 2.2, 5, 4);
      }
      else
      {
        Motorcycle veihicle = new Motorcycle("bracno", 2023, 250);
      }
      Console.ReadLine();

    }
  }
}
