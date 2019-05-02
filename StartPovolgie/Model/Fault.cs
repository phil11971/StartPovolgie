using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Fault
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int IdFaultStatus { get; set; }
        public int IdMaster { get; set; }

        public Fault(int id, string name, string desc, int idState, int idMaster)
        {
            Id = id;
            Name = name;
            Desc = desc;
            IdFaultStatus = idState;
            IdMaster = idMaster;
        }

        public Fault(string name, string desc, int idState, int idMaster)
        {
            Name = name;
            Desc = desc;
            IdFaultStatus = idState;
            IdMaster = idMaster;
        }

        public Fault(string name, string desc, int idState)
        {
            Name = name;
            Desc = desc;
            IdFaultStatus = idState;
        }
    }
}
