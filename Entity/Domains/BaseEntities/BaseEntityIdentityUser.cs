using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains.BaseEntities
{
    public abstract class BaseEntityIdentityUser : IdentityUser
    {

        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false), Column(TypeName = "datetime2")]
        public DateTime LastModifiedDate { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "datetime2")]
        public DateTime? DeActivatedDate { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime ActivatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
