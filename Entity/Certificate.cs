using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Certificate
    {
        public Certificate()
        {
            this.People = new HashSet<PersonBase>();
        }

        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }

        
        public virtual ICollection<PersonBase> People { get; set; }

    }
}
