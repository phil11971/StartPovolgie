using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class TypeServiceController
    {
        public bool Insert(TypeService typeService)
        {
            if (new TypeServiceDAO().Insert(typeService)) return true;
            else return false;
        }

        public bool Update(TypeService typeService)
        {
            if (new TypeServiceDAO().Update(typeService)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new TypeServiceDAO().DeleteById(id);
        }
    }
}
