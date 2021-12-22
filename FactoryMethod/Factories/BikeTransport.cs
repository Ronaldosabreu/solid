using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
  class BikeTransport : Transport
  {
    protected override IVehicle CreatreTransport()
    {
      return new Bike();
    }
  }
}
