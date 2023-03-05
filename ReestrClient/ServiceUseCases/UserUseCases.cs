using ReestrClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.ServiceUseCases
{
    internal interface UserUseCases
    {
        public Task<(AuthInfo, string)> LogIn(string login, string password);
        public Task<string> SignUp(string Name, string Lastname, string Login, string Password);
    }
}
