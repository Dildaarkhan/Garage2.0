namespace Garage2._0.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Garage2._0.DataAccessLayer.Garage2_0Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Garage2._0.DataAccessLayer.Garage2_0Context context)
        {
            var dt = DateTime.Now;

            context.Vehicles.AddOrUpdate(p => p.VehicleId,
                new Vehicle { RegistrationNumber = "BIL111", VehicleType = VehicleType.Car, Mark = "Volvo", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BIL222", VehicleType = VehicleType.Car, Mark = "Volkswagen", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BIL333", VehicleType = VehicleType.Car, Mark = "Mercedes-Benz", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BIL444", VehicleType = VehicleType.Car, Mark = "Ferrari", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BIL555", VehicleType = VehicleType.Car, Mark = "Citroën", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BUS111", VehicleType = VehicleType.Car, Mark = "Scania", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BUS222", VehicleType = VehicleType.Car, Mark = "Renault", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BUS333", VehicleType = VehicleType.Car, Mark = "Mercedes-Benz", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BUS444", VehicleType = VehicleType.Car, Mark = "Volvo", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "BUS555", VehicleType = VehicleType.Car, Mark = "MAN", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "MCF111", VehicleType = VehicleType.Car, Mark = "Yamaha", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "MCK222", VehicleType = VehicleType.Car, Mark = "Honda", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "MCG333", VehicleType = VehicleType.Car, Mark = "Harley-Davidson", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "MCH444", VehicleType = VehicleType.Car, Mark = "Kawasaki", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt },
                new Vehicle { RegistrationNumber = "MCJ555", VehicleType = VehicleType.Car, Mark = "Aprilia", Model = 2000, Color = "Black", NumberOfWheels = 4, ParkingTime = dt });
        }                                                                                       
    }
}
