using Entity.Domains.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains
{
    public class FinePayment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int FineId { get; set; }
        [ForeignKey(nameof(FineId))]
        public Fine Fine { get; set; }

        public DateTime PaidDate { get; set; }

        public bool IsPaid { get; set; }
    }
}
