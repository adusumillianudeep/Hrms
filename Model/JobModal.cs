using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class JobModal
    {
        public long JobId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public byte[] JobSpecification { get; set; }
        public Nullable<long> OrganizationId { get; set; }
    }
}
