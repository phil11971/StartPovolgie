using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class AcceptForRepairController
    {
        public bool Insert(AcceptForRepair acceptForRepair, out int idAccept)
        {
            if (new AcceptForRepairDAO().Insert(acceptForRepair, out idAccept)) return true;
            else return false;
        }

        public bool Update(AcceptForRepair acceptForRepair)
        {
            if (new AcceptForRepairDAO().Update(acceptForRepair)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new AcceptForRepairDAO().DeleteById(id);
        }
    }
}
