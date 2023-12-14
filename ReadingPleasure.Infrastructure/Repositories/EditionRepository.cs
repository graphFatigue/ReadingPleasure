using ReadingPleasure.Abstractions.Infrastructure;
using ReadingPleasure.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingPleasure.Infrastructure.Repositories
{
    public class EditionRepository : GenericRepository<Edition>, IEditionRepository
    {
        public EditionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
