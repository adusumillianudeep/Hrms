using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class CurrencyModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> OrganizationId { get; set; }
    }
}
