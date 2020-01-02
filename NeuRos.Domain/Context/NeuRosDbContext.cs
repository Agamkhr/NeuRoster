using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NeuRos.Domain;
using NeuRos.Domain.Entities;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace NeuRos.Domain.Context
{
    public class NeuRosDbContext : DbContext
    {
        public NeuRosDbContext(DbContextOptions<NeuRosDbContext> options) : base(options)
        {
        }
        public DbSet<NmsRos> NmsRoster { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NmsRos>()
                .HasKey(c => new { c.Date, c.MemberId });
            modelBuilder.Entity<ShiftSwap>()
               .HasKey(c => new { c.Month, c.MemberId,c.EmpId });
        }
        public /*Microsoft.EntityFrameworkCore.*/DbSet<ShiftSwap> ShiftSwaps { get; set; }
        public DbSet<NmsTeam> NmsTeams { get; set; }
    }
}
