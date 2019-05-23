using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class FaultController
    {
        public bool Insert(Fault fault)
        {
            if (new FaultDAO().Insert(fault)) return true;
            else return false;
        }

        public bool Update(List<Fault> faults)
        {
            if (new FaultDAO().Update(faults)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new FaultDAO().DeleteById(id);
        }
    }
}
