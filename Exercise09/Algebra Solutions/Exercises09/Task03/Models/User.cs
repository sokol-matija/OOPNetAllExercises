﻿using Newtonsoft.Json;

namespace Zadatak03.Models
{
    // Generated by using https://app.quicktype.io/
    public class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
