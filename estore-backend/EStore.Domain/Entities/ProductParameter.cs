using System;

namespace EStore.Domain.Entities
{
    public class ProductParameter
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}