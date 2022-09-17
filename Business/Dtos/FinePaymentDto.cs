using Entity.Domains;

namespace Business.Dtos
{
    public class FinePaymentDto
    {
      
        public int Id { get; set; }

        public int FineId { get; set; }
        public Fine Fine { get; set; }

        public DateTime PaidDate { get; set; }

        public bool IsPaid { get; set; }
    }
}
