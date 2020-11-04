using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeSpokedBike.Models
{
    public class Commission
    {
        public int CommissionID { get; set; }
        public string Salesperson { get; set; }
        public decimal CommissionAmountQ1 { get; set; }
        public decimal CommissionAmountQ2 { get; set; }
        public decimal CommissionAmountQ3 { get; set; }
        public decimal CommissionAmountQ4 { get; set; }
        
        
    }
}