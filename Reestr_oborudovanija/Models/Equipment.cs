namespace Reestr_oborudovanija.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? NameInList { get; set; } = null;
        public bool Accounting { get; set; }
        public string? InventoryNumber { get; set; } = null;
        public float BalanceValue { get; set; }
        public float Depreciation { get; set; }
        public float ResidualValue { get; set; }
        public int CountInList { get; set; }
        public int CountFact { get; set; }
        public int State_id { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public State State { get; set; }
        public bool Usages { get; set; }
        public int Status_id { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Status Status { get; set; }
        public string? TransferTo { get; set; } = null;
        public string? Required { get; set; } = null;
        public int Storage_id { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Storage Storage { get; set; }

        public override string ToString()
        {
            return $" Id: {Id}, \n Name: {Name}, \n NameInList: {NameInList}, \n Accounting: {Accounting}, \n InventoryNumber: {InventoryNumber}, \n BalanceValue: {BalanceValue}, \n Depreciation: {Depreciation}, \n ResidualValue: {ResidualValue}, \n CountInList: {CountInList}, \n CountFact: {CountFact}, \n State_id: {State_id}, \n Usages: {Usages}, \n Status_id: {Status_id}, \n TransferTo: {TransferTo}, \n Required: {Required}, \n Storage_id: {Storage_id}\n";
        }
    }

}
