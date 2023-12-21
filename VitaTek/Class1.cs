using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Text.Json;
namespace VitaTek
{
    internal class Passerelle
    {
      
        static HttpClient client = new HttpClient();
        public static async Task<List<Visiteur>> getUnDirecteurRegionnal(int id,int role)
        {
            List<Visiteur> lesVisiteurs = new List<Visiteur>();
            string url = "https://s5-5127.nuage-peda.fr/VitaTek/api.php?id="+id+"&role="+role;
            string repAPIenJson;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (!response.IsSuccessStatusCode)
                    throw new Exception();
                repAPIenJson = response.Content.ReadAsStringAsync().Result;
                lesVisiteurs = JsonSerializer.Deserialize<List<Visiteur>>(repAPIenJson);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("problème");
                Console.Write(e.Message);
            }
            return lesVisiteurs;
        }



    }
}
