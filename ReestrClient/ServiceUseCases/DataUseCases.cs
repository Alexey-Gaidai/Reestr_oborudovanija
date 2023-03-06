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
        public Task<(List<T>, string)> Get<T>(AuthInfo userInfo, string parameter);
        // универсальный post метод
        public Task<string> Post<T>(AuthInfo userInfo, string parameter, T item);
        // универсальный delete метод
        public Task<string> Delete(AuthInfo userInfo, string parameter, int id);
        // универсальный put метод
        public Task<string> Put<T>(AuthInfo userInfo, string parameter, int id, T item);
    }
}
