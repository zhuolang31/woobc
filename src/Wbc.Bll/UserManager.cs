using System;
using System.Collections.Generic;
using Wbc.Dal;

namespace Wbc.Bll
{
	public class UserManager
	{
		public long Register(string username, string displayName, string mobile, string password, string email, long companyId)
		{
			using (var ctx = new woobcEntities())
			{
				var user = new wbc_user
				{
					UserName = username,
					Password = CryptoHelper.SHA256(password),
					Email = email,
					CompanyID = companyId,
					DisplayName = displayName,
					Mobile = mobile,
					DateCreated = DateTime.Now,
				};
				ctx.wbc_user.Add(user);
				ctx.SaveChanges();
				return user.ID;
			}
		}

		public bool ValidateUser(string username, string password)
		{
			return false;
		}

		public void ActiveUser(long userId)
		{

		}

		public void DisableUser(long userId)
		{

		}

		private void ChangeStatus(long userId, int status)
		{

		}

		public wbc_user_ext GetUserInfo(long userId)
		{
			return null;
		}

		public void UpdateUserInfo(wbc_user_ext userInfo)
		{

		}

		public void AddPhotos(long userId, List<string> url)
		{

		}

		public void RemovePhotos(long userId, List<long> url)
		{

		}

		public void AuditUser(long userId)
		{

		}

		public List<wbc_user_ext> Search(wbc_user_ext userInfo)
		{
			return new List<wbc_user_ext>();
		}

		public void PostUsers(List<long> userIds)
		{

		}

	}
}
