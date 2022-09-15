using Entity.Domains.BaseEntities;
using Entity.Domains.SysEntities;
using Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains
{
    public class Product: BaseEntityNoIdentity<int>
    {
        public int CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }

        public int ProductCategoryId { get; set; }
        [ForeignKey(nameof(ProductCategoryId))]
        public ProductCategory ProductCategory { get; set; }

        public string Name { get; set; }

        public float Rate { get; set; }

        public int ClicksNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public ProductSize Size { get; set; }
    }
}
