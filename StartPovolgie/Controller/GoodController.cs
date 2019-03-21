using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class GoodController
    {
        public bool Insert(Good good)
        {
            if (new GoodDAO().Insert(good)) return true;
            else return false;
        }

        public bool Update(Good good)
        {
            if (new GoodDAO().Update(good)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new GoodDAO().DeleteById(id);
        }
    }
}
