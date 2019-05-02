using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class FaultStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public FaultStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public FaultStatus(string name)
        {
            Name = name;
        }

    }
}
