﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionProj.Models
{
    public partial class Employee
    {
        public int EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public string JobRole { get; set; }
        public string Department { get; set; }
    }
}
