using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderSample
{
    /// <summary>
    /// 游戏角色类，充当复杂产品对象
    /// </summary>
    class Actor
    {
        /// <summary>
        /// 角色类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 面容
        /// </summary>
        public string face { get; set; }
        /// <summary>
        /// 服装
        /// </summary>
        public string costume { get; set; }
        /// <summary>
        /// 发型
        /// </summary>
        public string hairstyle { get; set; }


    }
}
