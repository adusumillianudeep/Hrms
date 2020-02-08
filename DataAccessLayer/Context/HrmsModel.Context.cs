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
    }
}
