using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmploymentStatusModel
    {
        public long EmploymentStatusId { get; set; }
        public string Name { get; set; }
        public Nullable<long> OrganizationId { get; set; }
    }
}
