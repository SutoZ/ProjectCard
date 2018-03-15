using ProjectCard.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectCard.DAL
{
    public class Systems : DbContext
    {
        public Systems() : base("Systems")
        {

        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<DepositAccount> DepositAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
    
    
}