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
        public int Price { get; set; }
        public SparePartStatus SparePartStatus { get; set; }

        public SparePart(string name)
        {
            Name = name;
        }

        public SparePart(string name, string desc, int cnt, int price, SparePartStatus sparePartStatus) : this(name)
        {
            Desc = desc;
            Cnt = cnt;
            Price = price;
            SparePartStatus = sparePartStatus;
        }

        public SparePart(int idSparePart, string name, string desc, int cnt, int price, SparePartStatus sparePartStatus) : this(name, desc, cnt, price, sparePartStatus)
        {
            IdSparePart = idSparePart;
        }
    }
}
