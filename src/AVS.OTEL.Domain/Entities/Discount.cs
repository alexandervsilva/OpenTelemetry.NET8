using AVS.OTEL.Domain.Commons;
using AVS.OTEL.Domain.Enums;

namespace AVS.OTEL.Domain.Entities
{
    public class Discount : BaseAuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Percent { get; set; }
        public DiscountStatus Status { get; set; }
    }
}
