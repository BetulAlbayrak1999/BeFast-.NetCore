

using Entity.Domains;

namespace Business.Dtos
{
    public class ReviewDto 
    {
        public ReviewDto()
        {
            if (!(Rate >= 0 && Rate <= 5))
                throw new InvalidOperationException("Rating should be between 0 and 5");
        }

        public int Id { get; set; }

        
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }    

        public string ImagePath { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public string Subject { get; set; }

        public float Rate { get; set; }

       
        public int ReferenceId { get; set; }

       
        public string ReferenceType { get; set; }
    }
}
