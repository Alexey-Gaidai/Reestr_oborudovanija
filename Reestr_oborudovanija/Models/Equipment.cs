﻿namespace Reestr_oborudovanija.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public int State_id { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public State State { get; set; }
        public bool Usages { get; set; }
        public int Status_id { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Status Status { get; set; }
        public string TransferTo { get; set; }
        public string Required { get; set; }
        public int Storage_id { get; set; }
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public Storage Storage { get; set; }
    }
}
