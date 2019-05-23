using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class ReturnFromRepair
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public DateTime IssueDate { get; set; }
        public float AmountRepair { get; set; }
        public float Total { get; set; }

        public ReturnFromRepair(int id, string desc, DateTime issueDate, float amountRepair, float total)
        {
            Id = id;
            Desc = desc;
            IssueDate = issueDate;
            AmountRepair = amountRepair;
            Total = total;
        }
    }
}
