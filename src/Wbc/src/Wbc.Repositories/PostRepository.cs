using Wbc.Domain.Models;
using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
	public class PostRepository : Repository<Post, long>, IPostRepository
	{
	}
}
