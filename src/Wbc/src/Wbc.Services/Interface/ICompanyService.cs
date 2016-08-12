using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wbc.Domain.Models;

namespace Wbc.Services.Interface
{
    interface ICompanyService
    {
        Task<Company> GetCompanyAsync(long companyId);
    }
}
