using System;

namespace Wbc.Domain.Models
{

	//	CREATE TABLE `wbc_company` (
	//  `ID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '公司主键',
	//  `Name` varchar(45) NOT NULL COMMENT '公司名称',
	//  `EmailSuffix` varchar(20) NOT NULL COMMENT '邮箱后缀',
	//  `Remark` varchar(200) NOT NULL COMMENT '备注',
	//  `DateCreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '创建时间',
	//  `DataChange_LastTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '最后更新时间',
	//  PRIMARY KEY(`ID`),
	//  UNIQUE KEY `ID_UNIQUE` (`ID`),
	//  KEY `idx_DataChange_LastTime` (`DataChange_LastTime`)
	//) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT = '公司';

	/// <summary>
	/// 公司
	/// </summary>
	public class Company : AggregateRoot<long>
	{
		/// <summary>
		/// 公司主键
		/// </summary>
		public override long Id { get; set; }

		/// <summary>
		/// 公司名称
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 邮箱后缀
		/// </summary>
		public string EmailSuffix { get; set; }

		/// <summary>
		/// 备注
		/// </summary>
		public string Remark { get; set; }

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
