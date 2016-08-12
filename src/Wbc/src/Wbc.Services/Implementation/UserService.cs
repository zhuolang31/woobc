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
    public class UserService : IUserService
    {
        private IUserRepository _userRepository = RepositoryHelper.Repository.GetUserRepository();

        public Task<long> AddUserAsync(User user)
        {
            return _userRepository.AddAsync(user);
        }

        public Task<User> GetUserAsync(long userId)
        {
            return _userRepository.GetByIdAsync(userId);
        }
    }
}
