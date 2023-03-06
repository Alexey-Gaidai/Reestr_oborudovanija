using Newtonsoft.Json;
using ReestrClient.Models;
using ReestrClient.ServiceUseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.Service
{
    internal class DataImpl : DataUseCases
    {
        public async Task<(List<T>, string)> Get<T>(AuthInfo userInfo, string parameter)
        {
            string data;
            var baseAddress = new Uri("https://localhost:7073");
            string url = $"/api/{parameter}/";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {userInfo.access_token}");
                    client.DefaultRequestHeaders.Add("Username", userInfo.username);
                    var result = await client.GetAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
                    data = encoding.GetString(bytes, 0, bytes.Length);
                    message = result.StatusCode.ToString();
                    result.EnsureSuccessStatusCode();

                }
                var equipments = JsonConvert.DeserializeObject<List<T>>(data);
                return (equipments, message);
            }
            catch
            {
                return (default, message);
            }

        }
        // универсальный post метод
        public async Task<string> Post<T>(AuthInfo userInfo, string parameter, T item)
        {
            var baseAddress = new Uri("https://localhost:7073");
            string url = $"/api/{parameter}/";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {userInfo.access_token}");
                    client.DefaultRequestHeaders.Add("Username", userInfo.username);
                    var result = await client.PostAsJsonAsync(url, item);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
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

        // универсальный delete метод
        public async Task<string> Delete(AuthInfo userInfo, string parameter, int id)
        {
            var baseAddress = new Uri("https://localhost:7073");
            string url = $"/api/{parameter}/{id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {userInfo.access_token}");
                    client.DefaultRequestHeaders.Add("Username", userInfo.username);
                    var result = await client.DeleteAsync(url);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
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

        // универсальный put метод
        public async Task<string> Put<T>(AuthInfo userInfo, string parameter, int id,T item)
        {
            var baseAddress = new Uri("https://localhost:7073");
            string url = $"/api/{parameter}/{id}";
            string message = "";
            try
            {
                using (var client = new HttpClient(new HttpClientHandler()) { BaseAddress = baseAddress })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {userInfo.access_token}");
                    client.DefaultRequestHeaders.Add("Username", userInfo.username);
                    var result = await client.PutAsJsonAsync(url, item);
                    var bytes = await result.Content.ReadAsByteArrayAsync();
                    Encoding encoding = Encoding.GetEncoding("utf-8");
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
