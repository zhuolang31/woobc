using Wbc.Domain.Models;
using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
	public class UserExtensionRepository : Repository<UserExtension, long>, IUserExtensionRepository
	{
	}
}
