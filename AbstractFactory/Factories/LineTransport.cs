using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
  class LineTransport : ITransportFactory
  {
    public IAircraft CreateTransporteAircraft()
    {
      return new Drone();
    }

    public ILandVehicle CreateTransporteVehicle()
    {
      return new Patinete();
    }
  }
}