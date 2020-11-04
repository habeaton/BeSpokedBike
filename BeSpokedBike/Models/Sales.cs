using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace BeSpokedBike.Models
{
    public class Sales
    {
        public int SalesID { get; set; }
        public string ProductName { get; set; }
        public string SalespersonName { get; set; }
        public string CustomerName { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CommissionPercentage { get; set; }
        [DataType(DataType.Date)]
        public DateTime SalesDate { get; set; }
    }
}