using Builder.Builders.Implementation;
using Builder.Directors;
using System.Globalization;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which vehicle do you want to build?");
            Console.WriteLine("1 - Truck");
            Console.WriteLine("2 - Motorcycle");
            var option = Console.ReadLine();

            var director = new Director(new VehicleBuilder());

            switch (option)
            {
                case "1":
                    var truck = director.BuildVolvoTruck();
                    ShowVehicleBuilded(truck.VehicleType.ToString(), truck.Engine.Power, truck.TransmissionType.ToString(), truck.Seats);                    
                    break;

                case "2":
                    var motorcycle = director.BuildMotorCycleCB500Honda();
                    ShowVehicleBuilded(motorcycle.VehicleType.ToString(), motorcycle.Engine.Power, motorcycle.TransmissionType.ToString(), motorcycle.Seats);                    
                    break;
            }
        }

        static void ShowVehicleBuilded(string vehicleType, int power, string transmissionType, int seats)
        {
            Console.WriteLine($"Vehicle built: {vehicleType} with {power} HP | Transmission type: {transmissionType} | Seats: {seats}");
        }
    }
}