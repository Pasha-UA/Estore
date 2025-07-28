using System;

namespace EStore.Domain.Entities
{
    public class VolumePrice
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public string CurrencyId { get; set; } = string.Empty;
        public decimal Value { get; set; }
    }
}