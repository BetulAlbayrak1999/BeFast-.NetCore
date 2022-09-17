using Entity.Domains;
using Entity.Domains.BaseEntities;
using System;

namespace Business.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? DeActivatedDate { get; set; }


        public DateTime? ActivatedDate { get; set; }

        public bool IsActive { get; set; }
        public string Name { get; set; }
        public string WorkingTime { get; set; }
        public string WorkingTimeWE { get; set; }
        public string ImageFile { get; set; }
        public string Location { get; set; }
        public string LocationLink { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public int ClicksNumber { get; set; }
        public int OrdersNumber { get; set; }
        public float Rate { get; set; }

        public int RegionId { get; set; }
        public RegionDto Region { get; set; }
    }
}
