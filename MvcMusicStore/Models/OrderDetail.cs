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
    /// 订单详情类
    /// </summary>
    public partial class OrderDetail
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int OrderDetailId { get; set; }

        /// <summary>
        /// 订单编号[外键]
        /// </summary>
        public int OrderId { get; set; }

        /// <summary>
        /// 专辑编号
        /// </summary>
        public int AlbumId { get; set; }

        /// <summary>
        /// 购买数量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal UnitPrice { get; set; }
    

        /// <summary>
        /// 专辑对象
        /// </summary>
        public virtual Album Album { get; set; }
        /// <summary>
        /// 订单对象
        /// </summary>
        public virtual Order Order { get; set; }
    }
}