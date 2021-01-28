using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.ObjectModel;

namespace TestCosmosDBAPIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient(@"https://localhost:44332/Index");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);
            //var list = JsonConvert.DeserializeObject<ObservableCollection<Item>>(response.Content);
            Console.WriteLine(response.Content);
            Console.ReadKey();
        }
    }
}
