using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class SparePartController
    {
        public bool Insert(SparePart sparePart)
        {
            if (new SparePartDAO().Insert(sparePart)) return true;
            else return false;
        }

        public bool Update(SparePart sparePart)
        {
            if (new SparePartDAO().Update(sparePart)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new SparePartDAO().DeleteById(id);
        }
    }
}
