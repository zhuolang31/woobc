using System.Threading.Tasks;
using Wbc.Domain.Models;

namespace Wbc.Services.Contract
{
	public interface ICompanyService
	{
		Task<Company> GetCompanyAsync(long companyId);
	}
}
