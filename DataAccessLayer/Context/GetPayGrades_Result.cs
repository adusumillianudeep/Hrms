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
    
    public partial class GetPayGrades_Result
    {
        public int PayGradeId { get; set; }
        public string PayGrade { get; set; }
        public string Curreny { get; set; }
        public Nullable<decimal> MaximumSalary { get; set; }
        public Nullable<decimal> MinimumSalary { get; set; }
        public int GradeCurrenyId { get; set; }
    }
}
