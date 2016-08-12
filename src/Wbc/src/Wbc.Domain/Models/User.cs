using System;
using System.Collections.Generic;

namespace Wbc.Domain.Models
{
    /*
CREATE TABLE `wbc_user` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT COMMENT '用户主键',
  `CompanyID` bigint(20) NOT NULL COMMENT '公司ID',
  `UserName` varchar(45) NOT NULL COMMENT '用户名',
  `DisplayName` varchar(45) NOT NULL COMMENT '昵称',
  `Email` varchar(45) NOT NULL COMMENT '邮箱',
  `Password` varchar(45) NOT NULL COMMENT '密码',
  `Status` int(11) NOT NULL COMMENT '状态(0-未激活 1- 已激活 2-已无效)',
  `Mobile` varchar(45) NOT NULL COMMENT '手机号',
  `DateCreated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '创建时间',
  `DataChange_LastTime` timestamp NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '最后更新时间',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`),
  KEY `idx_DataChange_LastTime` (`DataChange_LastTime`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='用户表';
*/

    public class User : AggregateRoot<long>
    {
        /// <summary>
        /// 用户主键
        /// </summary>
        public override long Id { get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        public long CompanyId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 密码Salt
        /// </summary>
        public string PasswordSalt { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 状态(0-未激活 1- 已激活 2-已无效)
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime DateModified { get; set; }

        #region Extend
        /// <summary>
        /// 用户照片
        /// </summary>
        public IList<UserPhoto> Photos { get; set; }

        /// <summary>
        /// 用户扩展信息
        /// </summary>
        public UserExtension UserExtensionInfo { get; set; }

        /// <summary>
        /// 所在公司
        /// </summary>
        public Company CompanyInfo { get; set; } 
        #endregion
    }
}
