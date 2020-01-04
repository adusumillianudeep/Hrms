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

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        public string Note { get; set; }

    }

}
