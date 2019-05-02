using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class ClientController
    {
        public bool Insert(Client clinet)
        {
            if (new ClientDAO().Insert(clinet)) return true;
            else return false;
        }

        public bool Update(Client clinet)
        {
            if (new ClientDAO().Update(clinet)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new ClientDAO().DeleteById(id);
        }
    }
}
