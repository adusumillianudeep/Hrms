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
    
    public partial class WorkShift
    {
        public long WorkShiftId { get; set; }
        public string Name { get; set; }
        public System.TimeSpan From { get; set; }
        public System.TimeSpan To { get; set; }
        public Nullable<long> OrganizationId { get; set; }
    }
}
