using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
  class CarTransport : Transport
  {
    protected override IVehicle CreatreTransport()
    {
      return new Car();
    }
  }
}
