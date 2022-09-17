
using Entity.Domains;

namespace Business.Dtos
{
    public class UserPaymentDto 
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }


        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        public decimal TotalDiscount { get; set; }
         
        public decimal TotalAmount { get; set; } 
        public decimal TotalTax { get; set; }

        public string BillCode { get; set; }

        public bool IsPaid { get; set; }

        public string UserId { get; set; } 
        public ApplicationUser ApplicationUser { get; set; }

    }
}
