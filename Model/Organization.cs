using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Organization
    {
        public long OrganizationId { get; set; }

        public string Name { get; set; }

        public string TaxId { get; set; }

        public string RegistrationNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string Note { get; set; }

        public int? NoOfEmployees { get; set; }

        public bool? IsEEOEnabled { get; set; }

        public bool? IsCostCenterEnabled { get; set; }

        public string CostCenter { get; set; }

        public string Address2 { get; set; }

    }


}
