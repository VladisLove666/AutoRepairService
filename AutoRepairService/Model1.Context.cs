﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoRepairService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AutoRepairServiceEntities : DbContext
    {
        public AutoRepairServiceEntities()
            : base("name=AutoRepairServiceEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Mechanics> Mechanics { get; set; }
        public virtual DbSet<Monitoring> Monitoring { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<RequestExecution> RequestExecution { get; set; }
        public virtual DbSet<Requests> Requests { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
