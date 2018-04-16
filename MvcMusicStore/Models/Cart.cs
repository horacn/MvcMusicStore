//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcMusicStore.Models
{
    using System;
    using System.Collections.Generic;
    
    /// <summary>
    /// 购物车类
    /// </summary>
    public partial class Cart
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public int RecordId { get; set; }

        /// <summary>
        /// 购物车编号[Guid或用户名]
        /// </summary>
        public string CartId { get; set; }

        /// <summary>
        /// 专辑编号
        /// </summary>
        public int AlbumId { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// 购买日期
        /// </summary>
        public System.DateTime DateCreated { get; set; }
    

        /// <summary>
        /// 专辑对象
        /// </summary>
        public virtual Album Album { get; set; }
    }
}