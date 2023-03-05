using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameInList { get; set; } = null;
        public bool Accounting { get; set; }
        public string InventoryNumber { get; set; } = null;
        public float BalanceValue { get; set; }
        public float Depreciation { get; set; }
        public float ResidualValue { get; set; }
        public int CountInList { get; set; }
        public int CountFact { get; set; }
        public int State_id { get; set; }
        public bool Usages { get; set; }
        public int Status_id { get; set; }
        public string TransferTo { get; set; } = null;
        public string Required { get; set; } = null;
        public int Storage_id { get; set; }
    }
}
