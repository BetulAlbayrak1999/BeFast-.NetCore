using Entity.Domains.BaseEntities;
using Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; }

        public DateTime WantedDate { get; set; }

        public int CompanyId { get; set; }
        //[ForeignKey(nameof(CompanyId))]
        //public Company Company { get; set; }

        public string OrderCode { get; set; }

        //public OrderStatus OrderStatus { get; set; }
    }
}
