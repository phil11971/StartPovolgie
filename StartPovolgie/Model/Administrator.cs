using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Administrator : Employee
    {
        public Administrator(string login, string pass, 
                             string lastName, string firstName, string patronymic, 
                             string phone, string address) 
            : base(login, pass, lastName, firstName, patronymic, phone, address, "Администратор", true) {}

        public Administrator(int id, string login, string pass,
                             string lastName, string firstName, string patronymic,
                             string phone, string address)
            : base(id, login, pass, lastName, firstName, patronymic, phone, address, "Администратор", true) { }

    }
}
