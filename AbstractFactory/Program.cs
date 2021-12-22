using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
  class Program
  {

    static Application ConfigureApplication()
    {
      Application app;

      ITransportFactory transportFactory;

      string company = "Line";

      if (company == "Uber")
      {
        transportFactory = new UberTransport();
      }
      else if (company == "99")
      {
        transportFactory = new _99Transport();
      }
      else 
      {
        transportFactory = new LineTransport();
      }

      app = new Application(transportFactory);


      return app;
    }

    static void Main(string[] args)
    {
      Application app = ConfigureApplication();

      app.StartRoute();

      Console.ReadLine();
    }
  }
}
