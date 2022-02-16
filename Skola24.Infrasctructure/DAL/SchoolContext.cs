using Microsoft.EntityFrameworkCore;
using Skola24.Infrasctructure.Models;

namespace Skola24.Infrasctructure.DAL
{
    public interface ISchoolContext
    {
        DbSet<Student> Student { get; set; }
        DbSet<Absence> Absence{ get; set; }
        DbSet<GetTotalAbsenceResult> GetTotalAbsence { get; set; }
    }

    public class SchoolContext : DbContext, ISchoolContext
    {
        public SchoolContext() : base() { }
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Absence> Absence { get; set; }
        public DbSet<GetTotalAbsenceResult> GetTotalAbsence { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GetTotalAbsenceResult>(e => e.HasNoKey());
        }
    }
}