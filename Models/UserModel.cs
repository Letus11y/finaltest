using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ShowMens.Models
{
    public class UserModel
    {
        [JsonPropertyName("name")]
        public NameModel Name { get; set; }
        
        public int Age { get; set; }
        public string Email { get; set; }
        
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
         [JsonPropertyName("picture")]
        public PictureModel Picture { get; set; }
        
    }
}