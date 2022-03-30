﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EntityLayer;
using EntityLayer.TableEntity;

namespace DataLayer
{
    public class SchoolManagementApiContext: DbContext
    {
        public SchoolManagementApiContext() : base(DatabaseConnection.ConnectionString) { }

        public SchoolManagementApiContext(string connectionstring) : base(connectionstring) { }
        public SchoolManagementApiContext(string connectionstring, bool lazyLoading, bool creationProxy) : base(connectionstring)
        {
            this.Configuration.LazyLoadingEnabled = lazyLoading;
            this.Configuration.ProxyCreationEnabled = creationProxy;
        }
        public SchoolManagementApiContext(bool lazyLoading) : base()
        {
            this.Configuration.LazyLoadingEnabled = lazyLoading;
        }
        public SchoolManagementApiContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<MatiereEntity> matieres { get; set; }
        public DbSet<ProffesseurEntity> proffesseurs { get; set; }
        public DbSet<EtudiantEntity> etudiants { get; set; }
        public DbSet<ClasseEntity> classes { get; set; }

    }
}
