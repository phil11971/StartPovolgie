using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class WorkStatusController
    {
        public bool Insert(WorkStatus workStatus)
        {
            if (new WorkStatusDAO().Insert(workStatus)) return true;
            else return false;
        }

        public bool Update(WorkStatus workStatus)
        {
            if (new WorkStatusDAO().Update(workStatus)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new WorkStatusDAO().DeleteById(id);
        }
    }
}
