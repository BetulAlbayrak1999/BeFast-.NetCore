using Entity.Domains;

namespace Business.Dtos
{
    public class OrderProductDto
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public ProductDto Product { get; set; }

        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
