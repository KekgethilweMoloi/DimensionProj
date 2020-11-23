using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionProj.Models
{
    public partial class JobInformation
    {
        public int JobInfoId { get; set; }
        public string JobRole { get; set; }
        public string JobLevel { get; set; }
        public string StandardHours { get; set; }
        public string EmployeeCount { get; set; }
        public string BusinessTravel { get; set; }
        public string StockOptionLevel { get; set; }
    }
}
