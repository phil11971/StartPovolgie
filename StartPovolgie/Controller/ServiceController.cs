using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class ServiceController
    {
        public bool Insert(Service service)
        {
            if (new ServiceDAO().Insert(service)) return true;
            else return false;
        }

        public bool Update(Service service)
        {
            if (new ServiceDAO().Update(service)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new ServiceDAO().DeleteById(id);
        }
    }
}
