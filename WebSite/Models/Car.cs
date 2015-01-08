using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    [Table("Car")]
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Facility { get; set; }
        //public string SaleDate { get; set; }
        public string Odometer { get; set; }
        public string Title { get; set; }
        //public string EstRetailValue { get; set; }
        public string TitleStateType { get; set; }
        public string VIN { get; set; }
        public string BodyStyle { get; set; }
        public string Color { get; set; }
        public string Drive { get; set; }
        public string Cylinders { get; set; }
        public string Fuel { get; set; }
        //public string Keys { get; set; }
        public string SpecialNote { get; set; }
        public string Images { get; set; }
        public string VehicleType { get; set; }

        public virtual ICollection<CarRequest> CarRequests { get; set; }
    }
}