﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HrmsEntities : DbContext
    {
        public HrmsEntities()
            : base("name=HrmsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CostCenter> CostCenters { get; set; }
        public virtual DbSet<DataGroupPermission> DataGroupPermissions { get; set; }
        public virtual DbSet<EmployeeAction> EmployeeActions { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<OrganizationLocation> OrganizationLocations { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<RoleDataGroupPermission> RoleDataGroupPermissions { get; set; }
        public virtual DbSet<RoleEmployeeAction> RoleEmployeeActions { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<RoleTypesDataGroupPermission> RoleTypesDataGroupPermissions { get; set; }
        public virtual DbSet<RoleTypeWorkflowManagement> RoleTypeWorkflowManagements { get; set; }
        public virtual DbSet<RoleWorkflowAction> RoleWorkflowActions { get; set; }
        public virtual DbSet<UserRegion> UserRegions { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkflowManagement> WorkflowManagements { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<License> Licenses { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Membership> Memberships { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<EmploymentStatu> EmploymentStatus { get; set; }
        public virtual DbSet<JobCategory> JobCategories { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<SalaryComponent> SalaryComponents { get; set; }
        public virtual DbSet<WorkShift> WorkShifts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<GradeCurrency> GradeCurrencies { get; set; }
        public virtual DbSet<PayGrade> PayGrades { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SectionField> SectionFields { get; set; }
    
        public virtual ObjectResult<GetPayGrades_Result> GetPayGrades()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPayGrades_Result>("GetPayGrades");
        }
    }
}
