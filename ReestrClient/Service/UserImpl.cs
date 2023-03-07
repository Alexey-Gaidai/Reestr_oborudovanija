using Newtonsoft.Json;
using ReestrClient.Models;
using ReestrClient.ServiceUseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.Service
{
    internal class UserImpl: UserUseCases
    {
        public string tokenKey;
        AuthInfo authInfo;
        public async Task<(AuthInfo, string)> LogIn(string login, string password)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7073");
            string url = "/token";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", login),
                new KeyValuePair<string, string>("password", password),
            });
            try
            {
                using (var client = new HttpClient { BaseAddress = baseAddress })
                {
                    var result = await client.PostAsync(url, content);
                    var bytes = await result.Content.ReadAsByteArrayAsync();

                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    result.EnsureSuccessStatusCode();
                    message = result.StatusCode.ToString();
                }
                authInfo = JsonConvert.DeserializeObject<AuthInfo>(data);
                Console.WriteLine(authInfo.access_token);
                return (authInfo, message);
            }
            catch
            {
                return (default, message);
            }

        }
        public async Task<string> SignUp(string Name, string Lastname, string Login, string Password)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7073");
            string url = "/signup";
            string message = "";

            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("name", Name),
                new KeyValuePair<string, string>("lastname", Lastname),
                new KeyValuePair<string, string>("login", Login),
                new KeyValuePair<string, string>("password", Password),
            });

            try
            {
                using (var client = new HttpClient { BaseAddress = baseAddress })
                {
                    var result = await client.PostAsync(url, content);
                    var bytes = await result.Content.ReadAsByteArrayAsync();

                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();
                }
                return message;
            }
            catch
            {
                return message;
            }

        }

    }
}
