using System;
using System.Threading.Tasks;
using Wbc.Domain.Models;
using Wbc.Domain.Repositories;
using Wbc.Repositories;
using Wbc.Services.Contract;

namespace Wbc.Services.Implementation
{
	public class UserService : IUserService
    {
        private IUserRepository _userRepository = RepositoryHelper.Repository.GetUserRepository();

        public Task<long> RegisterAsync(User user)
        {
            return _userRepository.AddAsync(user);
        }

        public Task<User> GetUserAsync(long userId)
        {
            return _userRepository.GetByIdAsync(userId);
        }

        public Task<Tuple<bool, string>> LoginAsync(string userName, string pwd)
        {
            throw new NotImplementedException();
        }

        public Task ChangePasswordAsync(long userId, string newPwd)
        {
            throw new NotImplementedException();
        }

        public Task FillUserInfoAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task UploadUserPhotoAsync(UserPhoto photo)
        {
            throw new NotImplementedException();
        }

        public Task PostUserInfoAsync(long userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserDetailByUserIdAsync(long userId)
        {
            return _userRepository.GetUserDetailByUserIdAsync(userId);
        }
    }
}
