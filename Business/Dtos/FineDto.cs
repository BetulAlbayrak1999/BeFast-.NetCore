using Entity.Domains;
using Entity.Domains.BaseEntities;


namespace Business.Dtos
{
    public class FineDto
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public decimal Amount { get; set; }

        public DateTime FineDate { get; set; }
        public bool IsPaid { get; set; }

        public string Description { get; set; }
    }
}
