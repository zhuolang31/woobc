using System;
using System.Threading.Tasks;
using Wbc.Domain.Models;
using Wbc.Domain.Repositories;

namespace Wbc.Repositories
{
    public class UserRepository : Repository<User, long>, IUserRepository
    {
        public async Task<User> GetUserDetailByUserIdAsync(long userId)
        {
            var user = await this.GetByIdAsync(userId);
            var company = await RepositoryHelper.Repository.GetCompanyRepository().GetByIdAsync(user.CompanyId);
            var userExt = await RepositoryHelper.Repository.GetUserExtensionRepository().GetByIdAsync(userId);
            var userPhotos = await RepositoryHelper.Repository.GetUserPhotoRepository().GetAllAsync(p => p.UserId == userId);
            user.CompanyInfo = company;
            user.UserExtensionInfo = userExt;
            user.Photos = userPhotos;
            return user;
        }
    }
}
