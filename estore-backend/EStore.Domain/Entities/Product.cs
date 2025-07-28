using EStore.Domain.Entities;

namespace EStore.Domain;

public class Product
{
        public Guid Id { get; set; } // Changed from int to Guid
        public Guid? GroupId { get; set; } // For product variants
        public bool Available { get; set; }
        public string SellingType { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal? Price { get; set; } // Nullable for items without a price
        public string CurrencyId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public int StockQuantity { get; set; }
        public List<VolumePrice> VolumePrices { get; set; } = new List<VolumePrice>();
        public List<ProductParameter> Parameters { get; set; } = new List<ProductParameter>();

}