using ReadingPleasure.Abstractions.Infrastructure;
using ReadingPleasure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingPleasure.Infrastructure.Repositories
{
    public class PublishingHouseRepository : GenericRepository<PublishingHouse>, IPublishingHouseRepository
    {
        public PublishingHouseRepository(AppDbContext context) : base(context)
        {
        }
    }
}
