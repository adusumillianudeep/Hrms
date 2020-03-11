using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SalaryComponentModel
    {
        public long SalaryComponentId { get; set; }
        public string Name { get; set; }
        public bool Earning { get; set; }
        public bool Deduction { get; set; }
        public bool TotalPayable { get; set; }
        public bool CostToCompany { get; set; }
        public bool Amount { get; set; }
        public bool Percentage { get; set; }
        public Nullable<long> OrganizationId { get; set; }
    }
}
