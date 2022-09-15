using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains.BaseEntities
{
    public class BaseEntityNoIdentity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }


        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        public DateTime? DeActivatedDate { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime ActivatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
