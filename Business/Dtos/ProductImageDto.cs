using Entity.Domains;
using System;

namespace Business.Dtos
{
    public class ProductImageDto
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        //public string Name { get; set; }

        public string ImagePath { get; set; }
    }
}
