using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class TypeGood
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TypeGood(string name)
        {
            Name = name;
        }
        public TypeGood(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
