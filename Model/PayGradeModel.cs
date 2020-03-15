using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class PayGradeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public Nullable<int> OrganizationId { get; set; }

        public IList<GradeCurrencyModel> GradeCurrencyModels { get; set; }
    }
}
