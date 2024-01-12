using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRED.Models
{

    [Table("Employees")]
    public class Employee
    {
        public int EmployeeID { get; set; }


        public string Name { get; set; }


        public int Age { get; set; }


        public string City { get; set; }


        public string Gender { get; set; }

    }
}