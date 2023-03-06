using ReestrClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.ServiceUseCases
{
    internal interface DataUseCases
    {
        public Task<(List<T>, string)> GetEquipment<T>(string tokenKey, string parameter);
    }
}
