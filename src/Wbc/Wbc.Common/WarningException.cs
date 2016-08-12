using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wbc.Common
{
    public class WarningException : Exception
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public int ErrorCode { get; set; }

        public WarningException(string message, int errorcode) : base(message)
        {
            this.ErrorCode = errorcode;
            LogHelper.WriteWarning("业务warning", message);
        }
    }
}
