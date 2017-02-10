namespace Garage2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        VehicleId = c.Int(nullable: false, identity: true),
                        RegistrationNumber = c.String(nullable: false),
                        Color = c.String(maxLength: 50),
                        Mark = c.String(maxLength: 30),
                        Model = c.Int(nullable: false),
                        NumberOfWheels = c.Int(nullable: false),
                        VehicleType = c.Int(nullable: false),
                        ParkingTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vehicles");
        }
    }
}
