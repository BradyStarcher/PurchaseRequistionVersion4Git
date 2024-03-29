﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PurchaseRequisition.Models;

namespace PurchaseRequisition.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        private string connectionString = @"Server=localhost\SQLEXPRESS;database=CapstoneVersionFour;MultipleActiveResultSets=true;Trusted_Connection=True;";

        public DbSet<PurchaseRequisition.Models.Address> Address { get; set; }

        public DbSet<PurchaseRequisition.Models.Campus> Campus { get; set; }

        public DbSet<PurchaseRequisition.Models.College> College { get; set; }

        public DbSet<PurchaseRequisition.Models.Division> Division { get; set; }

        public DbSet<PurchaseRequisition.Models.Department> Department { get; set; }
    }
}
