using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class SparePart
    {
        public int IdSparePart { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int Cnt { get; set; }
        public float Price { get; set; }

        public SparePart(string name)
        {
            Name = name;
        }

        public SparePart(string name, string desc, int cnt, float price) : this(name)
        {
            Desc = desc;
            Cnt = cnt;
            Price = price;
        }

        public SparePart(int idSparePart, string name, string desc, int cnt, float price) : this(name, desc, cnt, price)
        {
            IdSparePart = idSparePart;
        }

        public SparePart(int idSparePart, string name, int cnt, float price)
        {
            IdSparePart = idSparePart;
            Name = name;
            Cnt = cnt;
            Price = price;
        }

        public SparePart(int idSparePart, int cnt, float price)
        {
            IdSparePart = idSparePart;
            Cnt = cnt;
            Price = price;
        }
    }
}
