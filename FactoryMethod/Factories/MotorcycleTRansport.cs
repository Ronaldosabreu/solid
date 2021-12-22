using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
  class MotorcycleTRansport : Transport
  {
    protected override IVehicle CreatreTransport()
    {
      return new Motorcycle();
    }
  }
}
