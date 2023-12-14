using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingPleasure.Domain.Entities
{
    public class Edition : IBaseEntity
    {
        public Guid Id { get; set; }
        public int YearOfPublication { get; set; }
        public Book Book { get; set; }
        public PublishingHouse PublishingHouse { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
