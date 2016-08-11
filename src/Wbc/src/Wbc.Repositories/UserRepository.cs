using Wbc.Domain.Models;
using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
	public class UserRepository : Repository<User, long>, IUserRepository
	{
	}
}
