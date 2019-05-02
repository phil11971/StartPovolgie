using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class AcceptForRepair
    {
        public int Id { get; set; }
        public string Equipment { get; set; }
        public string MechanicalDamage { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Сomment { get; set; }
        public int IdGood { get; set; }
        public int IdAdmin { get; set; }
        public int IdClient { get; set; }
        public LinkedList<Fault> Faults { get; set; }

        public AcceptForRepair(int id, string equipment, string mechanicalDamage, DateTime receiptDate, string сomment, int idGood, int idAdmin, int idClient, LinkedList<Fault> faults)
        {
            Id = id;
            Equipment = equipment;
            MechanicalDamage = mechanicalDamage;
            ReceiptDate = receiptDate;
            Сomment = сomment;
            IdGood = idGood;
            IdAdmin = idAdmin;
            IdClient = idClient;
            Faults = faults;
        }

        public AcceptForRepair(string equipment, string mechanicalDamage, DateTime receiptDate, string сomment, int idGood, int idAdmin, int idClient, LinkedList<Fault> faults)
        {
            Equipment = equipment;
            MechanicalDamage = mechanicalDamage;
            ReceiptDate = receiptDate;
            Сomment = сomment;
            IdGood = idGood;
            IdAdmin = idAdmin;
            IdClient = idClient;
            Faults = faults;
        }
    }
}
