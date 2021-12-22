using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Vehicles
{
  class Car : Vehicles
  {

    private int seats;
    private int doors;

    public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
    {

      this.seats = seats;
      this.doors = doors;
    }



  }
}
