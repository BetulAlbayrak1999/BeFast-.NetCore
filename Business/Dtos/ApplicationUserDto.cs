using Entity.Domains;
using Entity.Enums;

namespace Business.Dtos
{
    public class ApplicationUserDto 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public Gender Gender { get; set; }
        public UserType UserType { get; set; }

        public int RegionId { get; set; }
        public RegionDto Region { get; set; }

        public DateTime EntryDate { get; set; }
        public int OrdersNumber { get; set; }
        public bool IsActive { get; set; }
        public string UserCode { get; set; }
    }
}
