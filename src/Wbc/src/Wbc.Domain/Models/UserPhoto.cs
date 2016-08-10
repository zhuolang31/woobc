using System;

namespace Wbc.Domain.Models
{
	public class UserPhoto : AggregateRoot<long>
	{
		/// <summary>
		/// 主键
		/// </summary>
		public override long Id { get; set; }

		/// <summary>
		/// 用户ID
		/// </summary>
		public long UserId { get; set; }

		/// <summary>
		/// 照片名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 链接地址
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime DateCreated { get; set; }

		/// <summary>
		/// 最后更新时间
		/// </summary>
		public DateTime DateModified { get; set; }
	}
}
