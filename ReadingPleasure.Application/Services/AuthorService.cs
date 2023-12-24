using ReadingPleasure.Abstractions.Application.Services;
using ReadingPleasure.Common.DTOs.Author;
using ReadingPleasure.Common.Utility;

namespace ReadingPleasure.Application.Services
{
    public class AuthorService : IAuthorService
    {
        public Task<AuthorDto> CreateAuthorAsync(CreateAuthorDto createAuthorDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAuthorAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDto?> GetAuthorByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<PaginatedList<AuthorDto>> GetAuthorsAsync(int pageNumber = 1, int pageSize = 10, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAuthorAsync(Guid id, UpdateAuthorDto updateAuthorDto, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
