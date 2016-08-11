using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
	public class RepositoryFactory
	{
		public IUserRepository GetUserRepository()
		{
			return new UserRepository();
		}

		public IUserExtensionRepository GetUserExtensionRepository()
		{
			return new UserExtensionRepository();
		}

		public ICompanyRepository GetCompanyRepository()
		{
			return new CompanyRepository();
		}

		public IUserPhotoRepository GetUserPhotoRepository()
		{
			return new UserPhotoRepository();
		}

		public IPostRepository GetPostRepository()
		{
			return new PostRepository();
		}

	}
}
