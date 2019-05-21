using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartPovolgie.Model
{
    public class FaultSparePart
    {
        public int IdFault { get; set; }
        public List<SparePart> SpareParts { get; set; }

        public FaultSparePart(int idFault, List<SparePart> spareParts)
        {
            IdFault = idFault;
            SpareParts = spareParts;
        }

    }
}
