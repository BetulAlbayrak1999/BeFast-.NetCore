using Entity.Domains;
using Entity.Enums;


namespace Business.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public DateTime WantedDate { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public string OrderCode { get; set; }

        //public OrderStatus OrderStatus { get; set; }
    }
}
