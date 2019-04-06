using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nutritia.Models
{
    public class Product
    {

        [JsonProperty("brands_tags")]
        public List<string> BrandTags { get; set; }

        [JsonProperty("serving_size")]
        public string ServingSize { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("generic_name")]
        public string GenericName { get; set; }

    }
}
