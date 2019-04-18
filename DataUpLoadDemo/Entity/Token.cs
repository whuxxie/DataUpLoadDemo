using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUpLoadDemo.Entity
{
    public class Token
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary>
        /// 用户名对应签名Token
        /// </summary>
        public Guid SignToken { get; set; }


        /// <summary>
        /// Token过期时间
        /// </summary>
        public DateTime ExpireTime { get; set; }
    }
}
