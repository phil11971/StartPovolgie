using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Good
    {
        public int IdGood { get; set; }
        public string Name { get; set; }
        public TypeGood TypeGood { get; set; }

        public Good(string name)
        {
            Name = name;
        }

        public Good(string name, TypeGood typeGood) : this(name)
        {
            TypeGood = typeGood;
        }

        public Good(int idGood, string name, TypeGood typeGood)
        {
            IdGood = idGood;
            Name = name;
            TypeGood = typeGood;
        }
    }
}
