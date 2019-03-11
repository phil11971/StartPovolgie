using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class SparePartStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SparePartStatus(string name)
        {
            Name = name;
        }
        public SparePartStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
