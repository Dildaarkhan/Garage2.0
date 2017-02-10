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
                new Vehicle { RegistrationNumber = "BIL111", VehicleType = VehicleType.Car,  Mark= "Volvo",         Modell = "850", F�rg = "R�d", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL222", VehicleType = VehicleType.Car,  Mark = "Volkswagen",   Modell = "Golf", F�rg = "Gr�", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL333", VehicleType = VehicleType.Car,  Mark = "Mercedes-Benz",Modell = "220", F�rg = "Svart", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL444", VehicleType = VehicleType.Car,  Mark = "Ferrari",      Modell = "Testarossa", F�rg = "R�d", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BIL555", VehicleType = VehicleType.Car,  Mark = "Citro�n",      Modell = "C4", F�rg = "Vit", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BUS111", VehicleType = VehicleType.Car,  Mark = "Scania",       Modell = "850", F�rg = "Gul", AntalHjul = 4 },
                new Vehicle { RegistrationNumber = "BUS222", VehicleType = VehicleType.Car,  Mark = "Renault",      Modell = "Golf", F�rg = "R�d", AntalHjul = 6 },
                new Vehicle { RegistrationNumber = "BUS333", VehicleType = VehicleType.Car,  Mark = "Mercedes-Benz",Modell = "220", F�rg = "Bl�", AntalHjul = 6 },
                new Vehicle { RegistrationNumber = "BUS444", VehicleType = VehicleType.Car,  Mark = "Volvo",        Modell = "Testarossa", F�rg = "Svart", AntalHjul = 8 },
                new Vehicle { RegistrationNumber = "BUS555", VehicleType = VehicleType.Car,  Mark="MAN",            Modell = "C4", F�rg = "Gr�n", AntalHjul = 10 },
                new Vehicle { RegistrationNumber = "MCF111", VehicleType = VehicleType.Car, Mark = "Yamaha", Modell = "500cc", F�rg = "Gul", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCK222", VehicleType = VehicleType.Car, Mark = "Honda", Modell = "FCX", F�rg = "R�d", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCG333", VehicleType = VehicleType.Car, Mark = "Harley-Davidson", Modell = "Softail", F�rg = "Bl�", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCH444", VehicleType = VehicleType.Car, Mark = "Kawasaki", Modell = "ZX-12R", F�rg = "Svart", AntalHjul = 2 },
                new Vehicle { RegistrationNumber = "MCJ555", VehicleType = VehicleType.Car, Mark = "Aprilia", Modell = "RS125", F�rg = "Gr�n", AntalHjul = 3 });
        }                                                                                       
    }
}
