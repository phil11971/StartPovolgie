using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class MasterController
    {
        public bool Insert(Master master)
        {
            if (new MasterDAO().Insert(master)) return true;
            else return false;
        }

        /*public bool Update(Master master)
        {
            if (new MasterDAO().Update(master)) return true;
            else return false;
        }*/

        public void DeleteById(int id)
        {
            new MasterDAO().DeleteById(id);
        }
    }
}
