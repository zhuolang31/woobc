using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
	public class RepositoryFactory
	{
		public IUserRepository GetUserRepository()
		{
			return null;
		}

		public IUserExtensionRepository GetUserExtensionRepository()
		{
			return null;
		}

		public ICompanyRepository GetCompanyRepository()
		{
			return null;
		}

	}
}
