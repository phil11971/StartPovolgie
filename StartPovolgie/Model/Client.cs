using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }

        public Client(int id, string lastName, string firstName, string patronymic, string phone, string mail, string address)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Phone = phone;
            Mail = mail;
            Address = address;
        }

        public Client(string lastName, string firstName, string patronymic, string phone, string mail, string address)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Phone = phone;
            Mail = mail;
            Address = address;
        }
    }
}
