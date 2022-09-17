using Entity.Domains;
using Entity.Domains.BaseEntities;
using System;

namespace Business.Dtos
{
    public class CompanyPaymentDto 
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? DeActivatedDate { get; set; }


        public DateTime? ActivatedDate { get; set; }

        public bool IsActive { get; set; }


        public DateTime UpdatedDate { get; set; }

        public int OrderId { get; set; }
        public OrderDto Order { get; set; }


        public int CurrencyId { get; set; }
        public CurrencyDto Currency { get; set; }

        public decimal TotalDiscount { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal TotalTax { get; set; }

        public string BillCode { get; set; }

        public bool IsPaid { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
