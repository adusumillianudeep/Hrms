using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class WorkShiftModel
    {
        public long WorkShiftId { get; set; }
        public string Name { get; set; }
        public System.TimeSpan From { get; set; }
        public System.TimeSpan To { get; set; }

        public Nullable<long> OrganizationId { get; set; }
    }
}
