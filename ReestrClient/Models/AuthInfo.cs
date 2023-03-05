using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.Models
{
    internal class AuthInfo
    {
        public string access_token { get; set; }
        public string username { get; set; }
        public string role { get; set; }
        public string userId { get; set; }
    }
}
