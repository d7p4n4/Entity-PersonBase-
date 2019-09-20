using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entity
{
    class EntityMethods
    {
        public static IQueryable<PersonBase> findById(string contextName, string name)
        {
            IQueryable<PersonBase> p;

            using (var ctx = new PersonContext())
            {
                var query = ctx.People
                                .Where(s => s.name == name);

                p = query;
            }
            return p;
        }
    }
}
