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
    
    public partial class RoleEmployeeAction
    {
        public int RoleEmployeeActionId { get; set; }
        public int RoleId { get; set; }
        public int EmployeeActionId { get; set; }
    
        public virtual EmployeeAction EmployeeAction { get; set; }
        public virtual Role Role { get; set; }
    }
}