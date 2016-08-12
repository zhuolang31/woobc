using System;

namespace Wbc.Domain.Models
{
	/*
CREATE TABLE `wbc_post` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT 'Post主键',
  `UserID` bigint(20) NOT NULL COMMENT '用户ID',
  `Title` varchar(45) NOT NULL COMMENT '标题',
  `Remark` varchar(200) NOT NULL COMMENT '备注',
  `PostDate` datetime NOT NULL COMMENT '推送日期',
  `DateCreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '创建日期',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '最后更新时间',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='文章';
		 */
	public class Post : AggregateRoot<long>
	{
		/// <summary>
		/// Post主键
		/// </summary>
		public override long Id { get; set; }

		/// <summary>
		/// 用户ID
		/// </summary>
		public long UserId { get; set; }

		/// <summary>
		/// 标题
		/// </summary>
		public string Title { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }

		/// <summary>
		/// 推送日期
		/// </summary>
		public DateTime PostDate { get; set; }

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
