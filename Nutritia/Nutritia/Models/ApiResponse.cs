﻿using Newtonsoft.Json;

namespace Nutritia.Models
{
    public class ApiResponse
    {

        [JsonProperty("status")]
        public int Status { get; set; }
        
        [JsonProperty("status_verbose")]
        public string StatusVerbose { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }

    }
}
