using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class TypeService
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TypeService(string name)
        {
            Name = name;
        }
        public TypeService(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
