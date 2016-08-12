using System.Threading.Tasks;
using Wbc.Domain.Models;
using Wbc.Domain.Repositories;
using Wbc.Repositories;
using Wbc.Services.Contract;

namespace Wbc.Services.Implementation
{
	public class CompanyService : ICompanyService
    {
        private ICompanyRepository _companyRepository = RepositoryHelper.Repository.GetCompanyRepository();

        public Task<Company> GetCompanyAsync(long companyId)
        {
            return _companyRepository.GetByIdAsync(companyId);
        }
    }
}
