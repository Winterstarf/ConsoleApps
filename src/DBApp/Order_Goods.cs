//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_Goods
    {
        public int idOrder { get; set; }
        public int idGoods { get; set; }
        public int GoodsCount { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
