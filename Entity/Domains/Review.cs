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
    public class Review 
    {
        public Review()
        {
            if (!(Rate >= 0 && Rate <= 5))
                throw new InvalidOperationException("Rating should be between 0 and 5");
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser ApplicationUser { get; set; }    

        public string ImagePath { get; set; }

        public string FullName { get; set; }

        public string Description { get; set; }

        public string Subject { get; set; }

        public float Rate { get; set; }

       
        public int ReferenceId { get; set; }

       
        public string ReferenceType { get; set; }
    }
}
