using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionProj.Models
{
    public partial class Survey
    {
        public int SurveyId { get; set; }
        public string EnvironmentSatisfaction { get; set; }
        public string JobSatisfaction { get; set; }
        public string RelationshipSatisfaction { get; set; }
    }
}
