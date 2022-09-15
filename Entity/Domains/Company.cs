using Entity.Domains.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains
{
    public class Company: BaseEntityNoIdentity<int>
    {
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
        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; }
    }
}
