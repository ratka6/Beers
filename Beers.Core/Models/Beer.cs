using System;
using Newtonsoft.Json;

namespace Beers.Core.Models
{
    public class Beer
    {
        [JsonProperty("id")]
        private int Id { get; set; }
        
        [JsonProperty("name")]
        internal string Name { get; set; }

        [JsonProperty("tagline")]
        internal string Tagline { get; set; }
        
        [JsonProperty("image_url")]
        internal Uri ImageUrl { get; set; }
        
        [JsonProperty("brewers_tips")]
        internal string BrewersTips { get; set; }

        [JsonProperty("description")]
        internal string Description { get; set; }
    }
}