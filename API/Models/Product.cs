using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shop.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Sku { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int StockId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
        [JsonIgnore]
        public virtual Stock? Stock { get; set; }

        public int Quantity { get; set; }
    }
}