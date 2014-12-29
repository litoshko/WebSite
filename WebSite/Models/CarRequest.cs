using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebSite.Models
{
    [Table("CarRequest")]
    public class CarRequest
    {
        [Key]
        public int CarRequestId { get; set; }
        public string Comment { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }

        public virtual Car Car { get; set; }
        public virtual UserProfile UserProfile { get; set; }
    }
}