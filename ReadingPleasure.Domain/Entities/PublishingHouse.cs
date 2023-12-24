﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingPleasure.Domain.Entities
{
    public class PublishingHouse : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Information { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Edition> Editions { get; set; } = new List<Edition>();
    }
}
