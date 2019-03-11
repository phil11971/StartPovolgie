using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class WorkStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public WorkStatus(string name)
        {
            Name = name;
        }
        public WorkStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
