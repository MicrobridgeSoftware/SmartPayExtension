using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMARTPayExtension.TechLibrary
{
    public class ImportCSVFile
    {        
        public string Transdate { get; set; }
        public int CustomerId { get; set; }
        public int ContractorId { get; set; }
        public string ServiceCode { get; set; }
        public decimal ShiftTotal { get; set; }
    }
}
