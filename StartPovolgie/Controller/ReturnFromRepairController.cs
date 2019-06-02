using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class ReturnFromRepairController
    {
        public bool Insert(ReturnFromRepair returnFromRepair)
        {
            if (new ReturnFromRepairDAO().Insert(returnFromRepair)) return true;
            else return new ReturnFromRepairDAO().Update(returnFromRepair);
        }

        public bool Update(ReturnFromRepair returnFromRepair)
        {
            if (new ReturnFromRepairDAO().Update(returnFromRepair)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new ReturnFromRepairDAO().DeleteById(id);
        }

        public bool HasServiceInPeriod(DateTime dateS, DateTime datePo)
        {
            if (new ReturnFromRepairDAO().HasServiceInPeriod(dateS, datePo))
                return true;
            else
                return false;
        }
    }
}
