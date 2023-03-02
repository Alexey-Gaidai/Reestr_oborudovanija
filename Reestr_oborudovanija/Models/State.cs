using Newtonsoft.Json;

namespace Reestr_oborudovanija.Models
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public ICollection<Equipment> Equipments { get; set; }
    }
}
