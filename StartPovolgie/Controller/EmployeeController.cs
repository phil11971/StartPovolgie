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

        public bool Insert(Employee employee)
        {
            if (new EmployeeDAO().Insert(employee)) return true;
            else return false;
        }

        public bool Update(Employee employee)
        {
            if (new EmployeeDAO().Update(employee)) return true;
            else return false;
        }

        public void DeleteById(int id)
        {
            new EmployeeDAO().DeleteById(id);
        }
    }
}
