using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class SpecializationController
    {
        public bool Insert(Specialization specialization)
        {
            if (new SpecializationDAO().Insert(specialization)) return true;
            else return false;
        }

        public bool Update(Specialization specialization)
        {
            if (new SpecializationDAO().Update(specialization)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new SpecializationDAO().DeleteById(id);
        }
    }
}
