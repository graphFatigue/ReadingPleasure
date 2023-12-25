using ReadingPleasure.Abstractions.Infrastructure;
using ReadingPleasure.Domain.Entities;

namespace ReadingPleasure.Infrastructure.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}
