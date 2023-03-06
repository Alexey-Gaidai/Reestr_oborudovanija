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
        // универсальный get метод
        public Task<(List<T>, string)> Get<T>(string tokenKey, string parameter);
        // универсальный post метод
        public Task<string> Post<T>(string tokenKey, string parameter, T item);
        // универсальный delete метод
        public Task<string> Delete(string tokenKey, string parameter, int id);
        // универсальный put метод
        public Task<string> Put<T>(string tokenKey, string parameter, T item);
    }
}
