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

        public TypeGood(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public TypeGood(string name)
        {
            this.Name = name;
        }
    }
}
