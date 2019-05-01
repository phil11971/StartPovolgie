using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Master : Employee
    {
        public Dictionary<int, string> Spec { get; set; }

        public Master(int id, string login, string pass, 
                      string lastName, string firstName, string patronymic, 
                      string phone, string address, Dictionary<int, string> spec) 
            : base(id, login, pass, lastName, firstName, patronymic, phone, address, "Мастер", true) {
            Spec = spec;
        }

        public Master(string login, string pass,
                      string lastName, string firstName, string patronymic,
                      string phone, string address, Dictionary<int, string> spec)
            : base(login, pass, lastName, firstName, patronymic, phone, address, "Мастер", true)
        {
            Spec = spec;
        }
    }
}
