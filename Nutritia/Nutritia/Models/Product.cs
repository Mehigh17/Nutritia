using Newtonsoft.Json;
using Nutritia.Converters;
using System;
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

        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        [JsonProperty("quantity")]
        public string Quantity { get; set; }

        [JsonProperty("image_nutrition_url")]
        public string NutritionImageUrl { get; set; }

        [JsonProperty("image_ingredients_url")]
        public string IngredientsImageUrl { get; set; }

        [JsonProperty("allergens_hierarchy")]
        public List<string> AllergensHierarchy { get; set; }

        /// <summary>
        /// This is a string with categories separated by commas
        /// </summary>
        [JsonProperty("categories")]
        public string Categories { get; set; }

        /// <summary>
        /// This is a string with the allergens spearated by commas
        /// </summary>
        [JsonProperty("allergens")]
        public string Allergens { get; set; }

        [JsonProperty("created_t")]
        [JsonConverter(typeof(UnixEpochDateTimeConverter))]
        public DateTime CreatedDateTime { get; set; }

        [JsonProperty("nutrient_levels")]
        public Dictionary<string, object> NutrientLevels { get; set; }

        [JsonProperty("ingredients_text")]
        public string IngredientsTranscript { get; set; }

        [JsonProperty("_keywords")]
        public List<string> Keywords { get; set; }

        [JsonProperty("nutriments")]
        public Dictionary<string, object> Nutriments { get; set; }

        [JsonProperty("nutrition_grades_tags")]
        public List<string> NutritionGradeTags { get; set; }

        [JsonProperty("nova-group")]
        public string NovaGroup { get; set; }

        [JsonProperty("additives_tags")]
        public List<string> AdditivesTags { get; set; }

    }
}
