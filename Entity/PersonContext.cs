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
    }
}

