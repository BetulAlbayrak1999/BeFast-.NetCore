﻿
using Entity.Domains;

namespace Business.Dtos
{
    public class RegionDto 
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }

        public City City { get; set; }

    }
}
