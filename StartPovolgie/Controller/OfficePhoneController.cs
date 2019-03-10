using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class OfficePhoneController
    {
        public bool Insert(OfficePhone officePhone)
        {
            if (new OfficePhoneDAO().Insert(officePhone)) return true;
            else return false;
        }

        public bool Update(OfficePhone officePhone)
        {
            if (new OfficePhoneDAO().Update(officePhone)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new OfficePhoneDAO().DeleteById(id);
        }
    }
}
