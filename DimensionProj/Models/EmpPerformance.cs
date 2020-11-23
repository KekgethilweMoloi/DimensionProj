using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionProj.Models
{
    public partial class EmpPerformance
    {
        public int PerfomanceId { get; set; }
        public string PerfomanceRating { get; set; }
        public string JobInvolvement { get; set; }
        public string WorkLifeBalance { get; set; }
    }
}
