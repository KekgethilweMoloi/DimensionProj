using System;
using System.Collections.Generic;

#nullable disable

namespace DimensionProj.Models
{
    public partial class EmpHisory
    {
        public int EmpHistoryId { get; set; }
        public string NumCompaniesWorked { get; set; }
        public string TotalWorkingYears { get; set; }
        public string TrainingTimesLastYear { get; set; }
        public string YearsAtCompany { get; set; }
        public string YearsInCurrentRole { get; set; }
        public string YearsSinceLastPromotion { get; set; }
        public string YearsWithCurrManager { get; set; }
    }
}
