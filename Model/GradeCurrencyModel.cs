using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GradeCurrencyModel
    {
        public int Id { get; set; }
        public int PayGradeId { get; set; }
        public int CurrencyID { get; set; }
        public string Currency { get; set; }

        public Nullable<decimal> MinimumSalary { get; set; }
        public Nullable<decimal> MaximumSalary { get; set; }
    }
}
