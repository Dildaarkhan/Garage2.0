using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Garage2._0.Models
{
    public class Vehicle
    {
        [Key]
        [DisplayName("Registration Number")]
        [Required(ErrorMessage ="Required")]
        [RegularExpression(@"^[a-zA-Z]{3,10}[0-9]{3,10}$", ErrorMessage = "error Message ")]
        public string RegistrationNumber { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(30)]
        public string Mark { get; set; }

        [Range(1800,2017,ErrorMessage ="1800 to 2017 Model Can Park Here")]
        public int Model { get; set; }

        [DisplayName ("Number of Wheels")]
        [Range(0,20)]
        public int NumberOfWheels { get; set; }

        [DisplayName("Vehicle Type")]
        public VehicleType VehicleType { get; set; }
    }
    public enum VehicleType
    {
        Car,
        Bus,
        MotorCycle,
        Cylce,
        AirPlane,
        Boat,

    }

    
}