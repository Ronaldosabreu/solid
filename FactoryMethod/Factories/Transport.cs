using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
  abstract class  Transport
  {

    public void StartTransport()
    {
      IVehicle vehicle = CreatreTransport();

      vehicle.StartRoute();

    }

    protected abstract IVehicle CreatreTransport();


  }
}
