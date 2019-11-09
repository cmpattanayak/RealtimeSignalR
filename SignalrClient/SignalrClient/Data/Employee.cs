using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignalrClient.Data
{
    public class Employee
    {
        [Key]
        [Display(Name="Employee ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}