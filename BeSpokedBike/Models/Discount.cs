using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeSpokedBike.Models
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string ProductName { get; set; }
        public virtual Products Products { get; set; }
        [DataType(DataType.Date)]
        public DateTime BeginDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public int DiscountPercentage { get; set; }
    }
}