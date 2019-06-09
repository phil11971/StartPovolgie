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
        public string Desc { get; set; }
        public float CostElim { get; set; }
        public int IdAccept { get; set; }

        public Fault(int id, float costElim)
        {
            Id = id;
            CostElim = costElim;
        }

        public Fault(int id, string desc)
        {
            Id = id;
            Desc = desc;
        }

        public Fault(string desc)
        {
            Desc = desc;
        }

    }
}
