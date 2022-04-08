using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Addmition__Elgibilty_K_A.Areas.Identity.Data;
using Addmition__Elgibilty_K_A.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Addmition__Elgibilty_K_A.Areas.Identity.Data
{
    public class DataBaseAE : IdentityDbContext<Addmition__Elgibilty_K_AUser>
    {
        public DataBaseAE(DbContextOptions<DataBaseAE> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<admission_ligibility_request_SY>().ToTable("admission_ligibility_request_SY");

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Emplolyee> Employee { get; set; }
        // public DbSet<Admin> Admin { get; set; }
        public DbSet<statues_of_admission_elgibilty> statues_of_admission_elgibilty { get; set; }
        public DbSet<setting_of_specialties> setting_of_specialties { get; set; }
        public DbSet<Wishess> Wishss { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<admission_eligibility_request> admission_eligibility_request { get; set; }
        public DbSet<admission_ligibility_request_SY> admission_ligibility_request_SY { get; set; }
        public DbSet<Type_of_certificate> Type_of_certificate { get; set; }
        public DbSet<statues_of_student> Statues_of_student { get; set; }
        public DbSet<Acceptaple_Config> Acceptaple_configuration { get; set; }
    }
}
