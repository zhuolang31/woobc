using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wbc.Domain.Models;
using Wbc.Domain.Repositories;
using Wbc.Repositories;
using Wbc.Services.Interface;

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
