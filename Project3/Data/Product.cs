using System.Text.Json.Serialization;

namespace Project3.Data
{
    public class Product
    {
        public string name { get; set; }
        public productData data { get; set; }
    }
    public class productData
    {
        public int year { get; set; }
        public double price { get; set; }
        [JsonPropertyName("CPU model")]
        public string cpuModel { get; set; }
        [JsonPropertyName("Hard disk size")]
        public string hardDiskSize { get; set; }
    }

}
