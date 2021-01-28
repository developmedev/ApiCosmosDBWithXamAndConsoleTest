using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosDBMobile.Models
{
    public class Item
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Completed { get; set; }
    }
}
