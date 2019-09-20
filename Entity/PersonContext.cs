using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Entity
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonDB")
        {
            Database.SetInitializer<PersonContext>(new CreateDatabaseIfNotExists<PersonContext>());
        }

        public DbSet<PersonBase> People { get; set; }
        public DbSet<Certificate> Certificates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<PersonBase>()
                        .HasMany<Certificate>(s => s.Certificates)
                        .WithMany(c => c.People)
                        .Map(cs =>
                        {
                            cs.MapLeftKey("PersonRefId");
                            cs.MapRightKey("CertificateRefId");
                            cs.ToTable("PersonWithCerts");
                        });

        }
    }
}

