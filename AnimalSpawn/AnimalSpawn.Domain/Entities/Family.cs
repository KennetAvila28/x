using System;
using System.Collections.Generic;

namespace AnimalSpawn.Domain.Entities
{
    public partial class Family : BaseEntity
    {
        public Family()
        {
            Animal = new HashSet<Animal>();
        }

        //public int Id { get; set; }
        public string CommonName { get; set; }
        public string Code { get; set; }
       // public DateTime? CreateAt { get; set; }
        //public int? CreatedBy { get; set; }
       // public DateTime? UpdateAt { get; set; }
       // public int? UpdatedBy { get; set; }
       // public bool? Status { get; set; }

        public virtual ICollection<Animal> Animal { get; set; }
    }
}
