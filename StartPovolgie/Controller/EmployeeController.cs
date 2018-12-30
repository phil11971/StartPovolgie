using StartPovolgie.DAO;
using StartPovolgie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Controller
{
    public class EmployeeController
    {
        public Employee GetEmployeeByAuthorization(string login, string password)
        {
            return new EmployeeDAO().GetEmployeeByAuthorization(login, password);
        }
    }
}
