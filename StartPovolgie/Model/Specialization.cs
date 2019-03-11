using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Specialization
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Specialization(string name)
        {
            Name = name;
        }
        public Specialization(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
