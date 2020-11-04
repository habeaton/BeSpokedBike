using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeSpokedBike.Models
{
    public class Salesperson
    {
        public int SalespersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string TerminationDate { get; set; }
        public string Manager { get; set; }
    }
}