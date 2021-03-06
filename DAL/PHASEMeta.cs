﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Langben.DAL
{
    [MetadataType(typeof(PHASEMetadata))]//使用PHASEMetadata对PHASE进行数据验证
    public partial class PHASE 
    {
      
        #region 自定义属性，即由数据实体扩展的实体
        
        [Display(Name = "表整体")]
        public string OVERALL_TABLEIDOld { get; set; }
        
        #endregion

    }
    public partial class PHASEMetadata
    {
			[ScaffoldColumn(false)]
			[Display(Name = "主键", Order = 1)]
			public object ID { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "名称", Order = 2)]
			public object NAME { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "相位单位", Order = 3)]
			public object PHASE_UNIT { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "显示值", Order = 4)]
			public object DISPLAY_VALUE { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "显示值单位", Order = 5)]
			public object DISPLAY_VALUE_UNIT { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "标准值", Order = 6)]
			public object STANDARD_VALUE { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "标准值单位", Order = 7)]
			public object STANDARD_VALUE_UNIT { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "绝对误差", Order = 8)]
			public object ABSOLUTE_ERROR { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "绝对误差单位", Order = 9)]
			public object ABSOLUTE_ERROR_UNIT { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "不确定度", Order = 10)]
			public object UNCERTAINTY_DEGREE { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "不确定度单位", Order = 11)]
			public object UNCERTAINTY_DEGREE_UNIT { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "预备方案", Order = 12)]
			public object PREPARE_SCHEMEID { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "表整体", Order = 13)]
			public object OVERALL_TABLEID { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "创建时间", Order = 14)]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			public DateTime? CREATETIME { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "创建人", Order = 15)]
			public object CREATEPERSON { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "修改时间", Order = 16)]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			public DateTime? UPDATETIME { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "修改人", Order = 17)]
			public object UPDATEPERSON { get; set; }


    }
}
 

