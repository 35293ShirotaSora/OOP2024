using System;
using System.Security.Policy;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
namespace Exercise01 {
    public class Employee {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("hireDate")]
        public DateTime HireDate { get; set; }
    }
}

