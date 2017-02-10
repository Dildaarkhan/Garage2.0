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
            context.Vehicles.AddOrUpdate(p => p.VehicleId,
                new Vehicle { RegistrationNumber = "BIL111", VehicleType = VehicleType.Car,  Mark= "Volvo",         Modell = "850", Färg = "Röd", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL222", VehicleType = VehicleType.Car,  Mark = "Volkswagen",   Modell = "Golf", Färg = "Grå", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL333", VehicleType = VehicleType.Car,  Mark = "Mercedes-Benz",Modell = "220", Färg = "Svart", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL444", VehicleType = VehicleType.Car,  Mark = "Ferrari",      Modell = "Testarossa", Färg = "Röd", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL555", VehicleType = VehicleType.Car,  Mark = "Citroën",      Modell = "C4", Färg = "Vit", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BUS111", VehicleType = VehicleType.Car,  Mark = "Scania",       Modell = "850", Färg = "Gul", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BUS222", VehicleType = VehicleType.Car,  Mark = "Renault",      Modell = "Golf", Färg = "Röd", AntalHjul = 6 },
                new Vehicle { RegistrationNumber = "BUS333", VehicleType = VehicleType.Car,  Mark = "Mercedes-Benz",Modell = "220", Färg = "Blå", AntalHjul = 6 },
                new Vehicle { RegistrationNumber = "BUS444", VehicleType = VehicleType.Car,  Mark = "Volvo",        Modell = "Testarossa", Färg = "Svart", AntalHjul = 8 },
                new Vehicle { RegistrationNumber = "BUS555", VehicleType = VehicleType.Car,  Mark="MAN",            Modell = "C4", Färg = "Grön", AntalHjul = 10 },
                new Vehicle { RegistrationNumber = "MCF111", VehicleType = VehicleType.Car, Mark = "Yamaha", Modell = "500cc", Färg = "Gul", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCK222", VehicleType = VehicleType.Car, Mark = "Honda", Modell = "FCX", Färg = "Röd", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCG333", VehicleType = VehicleType.Car, Mark = "Harley-Davidson", Modell = "Softail", Färg = "Blå", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCH444", VehicleType = VehicleType.Car, Mark = "Kawasaki", Modell = "ZX-12R", Färg = "Svart", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCJ555", VehicleType = VehicleType.Car, Mark = "Aprilia", Modell = "RS125", Färg = "Grön", AntalHjul = 3 });
        }                                                                                       
    }
}
