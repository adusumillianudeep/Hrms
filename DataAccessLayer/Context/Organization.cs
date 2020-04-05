//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class Organization
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
        public Nullable<int> NoOfEmployees { get; set; }
        public Nullable<bool> IsEEOEnabled { get; set; }
        public Nullable<bool> IsCostCenterEnabled { get; set; }
        public string CostCenter { get; set; }
        public string Address2 { get; set; }
    }
}
