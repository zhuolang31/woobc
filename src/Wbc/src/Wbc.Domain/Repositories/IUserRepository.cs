using System.Threading.Tasks;
using Wbc.Domain.Models;

namespace Wbc.Domain.Repositories
{
	public interface IUserRepository : IRepository<User, long>
	{
        Task<User> GetUserDetailByUserIdAsync(long userId);
	}
}
