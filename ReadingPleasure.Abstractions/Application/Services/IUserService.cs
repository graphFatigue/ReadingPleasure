using ReadingPleasure.Common.DTOs.User;
using System.Threading.Tasks;

namespace ReadingPleasure.Abstractions.Application.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync(CancellationToken cancellationToken = default);
        Task<UserDto> GetUserByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task UpdateAsync(Guid id, UpdateUserDto updateUserDto, CancellationToken cancellationToken = default);
    }
}
