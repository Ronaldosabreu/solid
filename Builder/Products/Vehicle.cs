using Builder.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Products
{
  class Vehicle
  {
    public VehicleType vehycleType;
    public int seats;
    public Engine engine;
    public Transmission transmission;

    public VehicleType VehicleType { get => vehycleType; set=> vehycleType = value; }
    public int Seats { get => seats; set => seats = value; }
    public Engine Engine { get => engine; set => engine = value; }
    public Transmission Transmission { get => transmission; set => transmission = value; }
    
  }
}
