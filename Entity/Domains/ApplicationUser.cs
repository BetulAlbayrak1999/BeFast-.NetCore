using Entity.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Domains
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public Gender Gender { get; set; }
        public UserType UserType { get; set; }

        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public Region Region { get; set; }

        public DateTime EntryDate { get; set; }
        public int OrdersNumber { get; set; }
        public bool IsActive { get; set; }
        public string UserCode { get; set; }
    }
}
