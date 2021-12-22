using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.Landvehicles;

namespace AbstractFactory.App
{
  class Application
  {
    private IAircraft aircraft;
    private ILandVehicle vehicle;



    public Application(ITransportFactory factory)
    {
      aircraft= factory.CreateTransporteAircraft();
      vehicle=factory.CreateTransporteVehicle();
    }

    public void StartRoute()
    {
      vehicle.StartRoute();
      aircraft.StartRoute();
    }


  }
}
