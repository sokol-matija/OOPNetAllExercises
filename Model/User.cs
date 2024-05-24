using Newtonsoft.Json;

namespace Model
{
    public class User
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("avatar")]
        public Uri? Avatar { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}