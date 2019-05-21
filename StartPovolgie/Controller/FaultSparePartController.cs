using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class FaultSparePartController
    {
        public bool Insert(FaultSparePart faultSparePart)
        {
            if (new FaultSparePartDAO().Insert(faultSparePart)) return true;
            else return false;
        }

        public void DeleteById(int idFault, int idSparePart)
        {
            new FaultSparePartDAO().DeleteById(idFault, idSparePart);
        }
    }
}
