using Newtonsoft.Json;
using ReestrClient.Models;
using ReestrClient.ServiceUseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ReestrClient.Service
{
    internal class DataImpl : DataUseCases
    {
        public async Task<(List<T>, string)> GetEquipment<T>(string tokenKey, string parameter)
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
                    client.DefaultRequestHeaders.Add("Authorization", $"Bearer {tokenKey}");
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
    }
}
