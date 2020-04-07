using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeListModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; set; }

        public string JobTitle { get; set; }

        public string Status { get; set; }

        public string SubUnit { get; set; }
        public string CostCenter { get; set; }
        public string Location { get; set; }
        public string Supervisor { get; set; }
    }

    public class EmployeeDataModel
    {
        public int Id { get; set; }
        public bool AddLoginDetail { get; set; }

        public PersonalDetailModel personalDetail { get; set; }
    }


    public class PersonalDetailModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string Gender { get; set; }

        public int CountryId { get; set; }

        public DateTime DOB { get; set; }

        public string MaritalStatus { get; set; }

        public string LicenseNumber { get; set; }

        public DateTime LicenseExpiry { get; set; }

        public string NickName { get; set; }

        public string MilitaryService { get; set; }

        public bool Smoker { get; set; }

    }
}
