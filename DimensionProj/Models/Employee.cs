using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace DimensionProj.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string JobRole { get; set; }
        public string Department { get; set; }
    }
}
