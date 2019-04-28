using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }

        public Employee(int id, string login, string pass, 
                        string lastName, string firstName, string patronymic, 
                        string phone, string address, string job, bool status)
        {
            Id = id;
            Login = login;
            Password = pass;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Phone = phone;
            Address = address;
            Job = job;
            Status = status;
        }

        public Employee(string login, string pass,
                        string lastName, string firstName, string patronymic,
                        string phone, string address, string job, bool status)
        {
            Login = login;
            Password = pass;
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            Phone = phone;
            Address = address;
            Job = job;
            Status = status;
        }
    }
}
