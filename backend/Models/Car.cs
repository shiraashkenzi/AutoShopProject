using System.Text.Json.Serialization;

namespace AutoShop.API.Models {
    public class Car {
        public int Id { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [JsonIgnore]
        public List<User> Users { get; set; } = new();
    }
}