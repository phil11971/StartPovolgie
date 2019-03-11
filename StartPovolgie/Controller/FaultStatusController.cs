using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class FaultStatusController
    {
        public bool Insert(FaultStatus faultStatus)
        {
            if (new FaultStatusDAO().Insert(faultStatus)) return true;
            else return false;
        }

        public bool Update(FaultStatus faultStatus)
        {
            if (new FaultStatusDAO().Update(faultStatus)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new FaultStatusDAO().DeleteById(id);
        }
    }
}
