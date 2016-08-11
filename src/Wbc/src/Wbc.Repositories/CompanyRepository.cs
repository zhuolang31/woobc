using Wbc.Domain.Models;
using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
	public class CompanyRepository : Repository<Company, long>, ICompanyRepository
	{
	}
}
