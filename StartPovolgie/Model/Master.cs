using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Master : Employee
    {
        public int IdChief { get; set; }
        public Dictionary<int, string> Spec { get; set; }

        public Master(int id, string login, string pass, string lastName, string firstName, string patronymic, string phone, string address, int idChief, Dictionary<int, string> spec) : base(id, login, pass, lastName, firstName, patronymic, phone, address) {
            IdChief = idChief;
            Spec = spec;
        }
    }
}
