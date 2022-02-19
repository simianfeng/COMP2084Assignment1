using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace COMP2084Assignment1.Models
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Location)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.positionName)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .Property(e => e.OfficeLocation)
                .IsUnicode(false);

            modelBuilder.Entity<Position>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Position)
                .WillCascadeOnDelete(false);
        }
    }
}
