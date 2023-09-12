using System;

namespace Jarai.Patterns.Creational.Builder
{
    public class Program {


        public static void Main(string[] args) {


            // Director gets the concrete builder object from the client
            // (application code). That's because application knows better which
            // builder to use to get a specific product.
            var builder = new CarBuilder();
            var director = new Director();
            director.ConstructSportsCar(builder);
            var car = builder.GetResult();


            // The  product is often retrieved from a builder object, since
            // Director is not aware and not dependent on concrete builders and
            // products.

            Console.WriteLine("Car built:\n" + car.GetCarType());


            var manualBuilder = new CarManualBuilder();

            // Director may know several building recipes.
            director.ConstructSportsCar(manualBuilder);
            var carManual = manualBuilder.GetResult();
            Console.WriteLine("\nCar manual built:\n" + carManual.Print());
        }

    }
}

