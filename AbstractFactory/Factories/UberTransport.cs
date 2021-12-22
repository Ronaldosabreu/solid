﻿using AbstractFactory.Aircrafts;
using AbstractFactory.Landvehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
  class UberTransport : ITransportFactory
  {
    public IAircraft CreateTransporteAircraft()
    {
      return new Airplane();
    }

    public ILandVehicle CreateTransporteVehicle()
    {
      return new Car();
    }
  }
}
