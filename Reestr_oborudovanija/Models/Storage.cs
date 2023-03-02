using Newtonsoft.Json;

namespace Reestr_oborudovanija.Models
{
    public class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Equipment> Equipments { get; set; }
    }
}
