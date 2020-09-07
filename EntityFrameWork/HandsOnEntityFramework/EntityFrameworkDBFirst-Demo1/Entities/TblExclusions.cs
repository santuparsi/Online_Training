using System;
using System.Collections.Generic;

namespace EntityFrameworkDBFirst_Demo1.Entities
{
    public partial class TblExclusions
    {
        public int IntExclusionsId { get; set; }
        public string StrDrugNdc { get; set; }
        public string StrContractCode { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DtmCreated { get; set; }
        public DateTime DtmUpdated { get; set; }
    }
}
