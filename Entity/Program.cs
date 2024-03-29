﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new PersonBase();
            using (var ctx = new PersonContext())
            {
                p.setName("Izajás");

                ctx.People.Add(p);
                ctx.SaveChanges();
            }

            using (var ctx = new PersonContext())
            {
                var query = ctx.People
                                .Where(s => s.name == "Izajás")
                                .FirstOrDefault<PersonBase>();

                Console.WriteLine(query.getName());
            }

        }
    }
}
