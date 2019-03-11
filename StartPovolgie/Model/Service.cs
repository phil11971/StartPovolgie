using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class Service
    {
        public int IdService { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public TypeGood TypeGood { get; set; }

        public Service(string name)
        {
            Name = name;
        }

        public Service(string name, int price, TypeGood typeGood) : this(name)
        {
            Price = price;
            TypeGood = typeGood;
        }

        public Service(int idService, string name, int price, TypeGood typeGood)
        {
            IdService = idService;
            Name = name;
            Price = price;
            TypeGood = typeGood;
        }
    }
}
