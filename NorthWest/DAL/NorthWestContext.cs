﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using NorthWest.Models;

namespace NorthWest.DAL
{
    public class NorthWestContext : DbContext
    {
        public NorthWestContext() : base("NorthWestContext")
        {

        }
        //public DbSet<CompoundReceiptLog> CompoundReceiptLogs { get; set; }
        //public DbSet<TestTube> TestTubes { get; set; }
        public DbSet<SalesAgent> SalesAgents { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<Sample> Samples { get; set; }

        public DbSet<Assay> Assays { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Test_Material> Material_Tests { get; set; }
        public DbSet<TestTube> TestTubes { get; set; }

        public System.Data.Entity.DbSet<NorthWest.Models.Invoice> Invoices { get; set; }
    }
}