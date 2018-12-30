using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class TypeGoodController
    {
        public bool Insert(TypeGood typeGood)
        {
            if (new TypeGoodDAO().Insert(typeGood)) return true;
            else return false;
        }

        public bool Update(TypeGood typeGood)
        {
            if (new TypeGoodDAO().Update(typeGood)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new TypeGoodDAO().DeleteById(id);
        }
    }
}
