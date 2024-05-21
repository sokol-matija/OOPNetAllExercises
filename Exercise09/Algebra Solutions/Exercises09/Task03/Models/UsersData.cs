﻿using Newtonsoft.Json;

namespace Zadatak03.Models
{
    // Generated by using https://app.quicktype.io/
    // Note: class "Support" is not needed
    public class UsersData
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("data")]
        public List<User> Users { get; set; }
    }
}