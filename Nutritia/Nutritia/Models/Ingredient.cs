using Newtonsoft.Json;

namespace Nutritia.Models
{
    public class Ingredient
    {

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("percent")]
        public int Percent { get; set; }

    }
}
