using CosmosDBMobile.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDBMobile.Handlers
{
  

    public class RestHandler 
    {
        public RestHandler()
        {

        }
        public  List<Item> GetTems()
        {
            // this will not work on emulator
            var client = new RestClient(@"https://localhost:44332/Index");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Accept", "text/plain");
            var response = client.Execute(request);
            var list = JsonConvert.DeserializeObject<List<Item>>(response.Content);

            return list;
        }
    }
}
