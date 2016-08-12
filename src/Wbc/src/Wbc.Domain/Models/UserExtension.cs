using System;

namespace Wbc.Domain.Models
{
	public class UserExtension : AggregateRoot<long>
	{
        /// <summary>
        /// 用户Id
        /// </summary>
		public long UserId { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
		public DateTime Birthday { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
		public decimal Height { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
		public string City { get; set; }

        /// <summary>
        /// 出生地
        /// </summary>
		public string Birthplace { get; set; }

        /// <summary>
        /// 职位
        /// </summary>
		public string Occupation { get; set; }

        /// <summary>
        /// 父母亲描述信息
        /// </summary>
		public string ParentsDesc { get; set; }

        /// <summary>
        /// 是否独生子女
        /// </summary>
		public bool IsUniqueChild { get; set; }

        /// <summary>
        /// 收入描述
        /// </summary>
		public string IncomeDesc { get; set; }

        /// <summary>
        /// 兴趣爱好
        /// </summary>
		public string Hobby { get; set; }

        /// <summary>
        /// 是否接受异地恋
        /// </summary>
		public bool IsAcceptLongDistance { get; set; }

        /// <summary>
        /// 最低要求
        /// </summary>
		public string MinRequirement { get; set; }

        /// <summary>
        /// 特殊要求
        /// </summary>
		public string SpecialRequirement { get; set; }

        /// <summary>
        /// 简单介绍
        /// </summary>
		public string Introduction { get; set; }

        /// <summary>
        /// 给另一半的话
        /// </summary>
		public string ToPartner { get; set; }

        /// <summary>
        /// 状态（0-未审核 1-已审核)
        /// </summary>
		public int Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
		public DateTime DateCreated { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
		public DateTime DateModified { get; set; }

        /// <summary>
        /// 微信号
        /// </summary>
		public string Weichat { get; set; }

        /// <summary>
        /// QQ号
        /// </summary>
		public string QqNumber { get; set; }
	}
}
