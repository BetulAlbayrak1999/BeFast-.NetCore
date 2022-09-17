using Entity.Domains;
using Entity.Enums;

namespace Business.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? DeActivatedDate { get; set; }


        public DateTime? ActivatedDate { get; set; }

        public bool IsActive { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategoryDto ProductCategory { get; set; }

        public string Name { get; set; }

        public float Rate { get; set; }

        public int ClicksNumber { get; set; }

        public decimal Price { get; set; }

        public ProductSize Size { get; set; }
    }
}
