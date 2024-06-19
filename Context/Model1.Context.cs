﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuditSystem.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AuditSystemEntities : DbContext
    {
        public AuditSystemEntities()
            : base("name=AuditSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public DbSet<TblCustomer> TblCustomers { get; set; }
        public DbSet<TblDepartment> TblDepartments { get; set; }
        public DbSet<TblDesignation> TblDesignations { get; set; }
        public DbSet<TblEmployee> TblEmployees { get; set; }
        public DbSet<TblEmployeeHourlyRate> TblEmployeeHourlyRates { get; set; }
        public DbSet<TblGradeMaster> TblGradeMasters { get; set; }
        public DbSet<TblInternationalReferalMaster> TblInternationalReferalMasters { get; set; }
        public DbSet<TblIntroductionMaster> TblIntroductionMasters { get; set; }
        public DbSet<TblInvoiceNarrationMaster> TblInvoiceNarrationMasters { get; set; }
        public DbSet<TblInvoiceShortNarrationMaster> TblInvoiceShortNarrationMasters { get; set; }
        public DbSet<TblJob> TblJobs { get; set; }
        public DbSet<TblLegalStatusMaster> TblLegalStatusMasters { get; set; }
        public DbSet<TblLocation> TblLocations { get; set; }
        public DbSet<TblManager> TblManagers { get; set; }
        public DbSet<TblNatureMaster> TblNatureMasters { get; set; }
        public DbSet<TblNonEffectiveEmployee> TblNonEffectiveEmployees { get; set; }
        public DbSet<TblOpeningBalance> TblOpeningBalances { get; set; }
        public DbSet<TblPartner> TblPartners { get; set; }
        public DbSet<TblSectorMaster> TblSectorMasters { get; set; }
        public DbSet<TblSiteSetting> TblSiteSettings { get; set; }
        public DbSet<TblTitle> TblTitles { get; set; }
        public DbSet<TblWorkGroup> TblWorkGroups { get; set; }
        public DbSet<TblWorkType> TblWorkTypes { get; set; }
        public DbSet<VW_Customer> VW_Customer { get; set; }
        public DbSet<VW_Employee> VW_Employee { get; set; }
        public DbSet<VW_GradeMaster> VW_GradeMaster { get; set; }
        public DbSet<VW_InternationalReferalMaster> VW_InternationalReferalMaster { get; set; }
        public DbSet<VW_IntroductionMaster> VW_IntroductionMaster { get; set; }
        public DbSet<VW_InvoiceNarrationMaster> VW_InvoiceNarrationMaster { get; set; }
        public DbSet<VW_InvoiceShortNarrationMaster> VW_InvoiceShortNarrationMaster { get; set; }
        public DbSet<VW_LegalStatusMaster> VW_LegalStatusMaster { get; set; }
        public DbSet<VW_NatureMaster> VW_NatureMaster { get; set; }
        public DbSet<VW_OpeningBalance> VW_OpeningBalance { get; set; }
        public DbSet<VW_SectorMaster> VW_SectorMaster { get; set; }
    }
}
