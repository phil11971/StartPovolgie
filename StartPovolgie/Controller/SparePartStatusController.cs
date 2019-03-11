using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class SparePartStatusController
    {
        public bool Insert(SparePartStatus sparePartStatus)
        {
            if (new SparePartStatusDAO().Insert(sparePartStatus)) return true;
            else return false;
        }

        public bool Update(SparePartStatus sparePartStatus)
        {
            if (new SparePartStatusDAO().Update(sparePartStatus)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new SparePartStatusDAO().DeleteById(id);
        }
    }
}
