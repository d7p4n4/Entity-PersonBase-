using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{          [GUID("c8f60fd3-91f6-438f-9934-666e8cc6c939")]
    public class PersonBase
    {
        [Key]
        [GUID("0169d284-0796-4e57-a98f-78f022516494")]
        public String name { get; set; }
        [GUID("d8791a39-1f6b-4641-99a4-3f976f88b899")]
        public String address { get; set; }
        [GUID("b79f5215-14d8-480f-8820-257aa33cbf4a")]
        public Int32 age { get; set; }
        [GUID("ac33c921-0ba4-4513-a4c0-b9e7544c9a53")]
        public Boolean gender { get; set; }
        [GUID("9a40dde4-0aa7-4361-b396-439196ae4fbf")]
        public List<String> list { get; set; }

        public PersonBase() { }

        public String getName()
        {
            return name;
        }

        public String getAddress()
        {
            return address;
        }

        public Int32 getAge()
        {
            return age;
        }

        public Boolean getGender()
        {
            return gender;
        }

        public List<String> getList()
        {
            return list;
        }


        public void setName(String newValue)
        {
            name = newValue;
        }

        public void setAddress(String newValue)
        {
            address = newValue;
        }

        public void setAge(Int32 newValue)
        {
            age = newValue;
        }

        public void setGender(Boolean newValue)
        {
            gender = newValue;
        }

        public void setList(List<String> newValue)
        {
            list = newValue;
        }

    }
}
