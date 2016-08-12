using System;
using System.Threading.Tasks;
using Wbc.Domain.Models;

namespace Wbc.Services.Contract
{
	public interface IUserService
	{
		/// <summary>
		/// 注册用户
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		Task<long> RegisterAsync(User user);

		/// <summary>
		/// 用户登录
		/// </summary>
		/// <param name="userName"></param>
		/// <param name="pwd"></param>
		/// <returns></returns>
		Task<Tuple<bool, string>> LoginAsync(string userName, string pwd);

		/// <summary>
		/// 修改用户密码
		/// </summary>
		/// <param name="userId"></param>
		/// <param name="newPwd"></param>
		/// <returns></returns>
		Task ChangePasswordAsync(long userId, string newPwd);

		/// <summary>
		/// 完善用户信息
		/// </summary>
		/// <param name="user"></param>
		/// <returns></returns>
		Task FillUserInfoAsync(User user);


		/// <summary>
		/// 上传用户照片
		/// </summary>
		/// <param name="photo"></param>
		/// <returns></returns>
		Task UploadUserPhotoAsync(UserPhoto photo);

		/// <summary>
		/// 推送用户信息
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		Task PostUserInfoAsync(long userId);

		/// <summary>
		/// 获取用户详情信息
		/// </summary>
		/// <param name="userId"></param>
		/// <returns></returns>
		Task<User> GetUserDetailByUserIdAsync(long userId);
	}
}
