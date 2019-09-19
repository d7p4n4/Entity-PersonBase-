using System;
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
            using (var ctx = new PersonContext())
            {
                var p = new PersonBase();
                p.setName("Izajás");

                ctx.People.Add(p);
                ctx.SaveChanges();
            }
        }
    }
}
