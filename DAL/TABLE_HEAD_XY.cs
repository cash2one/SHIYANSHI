//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TABLE_HEAD_XY
    {
        public string ID { get; set; }
        public Nullable<decimal> ROW { get; set; }
        public Nullable<decimal> COLUMN { get; set; }
        public string CATEGORY { get; set; }
        public string TEST_ITEM_FORMATID { get; set; }
        public string DEFAULT_VALUE { get; set; }
        public Nullable<System.DateTime> CREATETIME { get; set; }
        public string CREATEPERSON { get; set; }
        public Nullable<System.DateTime> UPDATETIME { get; set; }
        public string UPDATEPERSON { get; set; }
    
        public virtual TEST_ITEM_FORMAT TEST_ITEM_FORMAT { get; set; }
    }
}