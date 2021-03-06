﻿using System;
using System.Collections.Generic;
using System.Linq;

using Common;
using Langben.DAL;
using Langben.BLL;
using System.Web.Mvc;
using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;

namespace Langben.App.Controllers
{
    /// <summary>
    /// 标准量传部工作信息查询
    /// </summary>
    public class VBIAOZHUNLIANGCHUANGONGZHUOController : BaseController
    {

        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        [SupportFilter]
        public ActionResult Index()
        {
        
            return View();
        }
           
        /// <summary>
        /// 异步加载数据
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        [HttpPost]
        [SupportFilter]
        public JsonResult GetData(string id, int page, int rows, string order, string sort, string search)
        {

            int total = 0;
            string a = string.Empty;
            List<VBIAOZHUNLIANGCHUANGONGZHUO> queryData = m_BLL.GetByParam(id, page, rows, order, sort, search, ref total);
            return Json(new datagrid
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
					,WEITUODANWEI = s.WEITUODANWEI
					,SUOSHUDANWEI = s.SUOSHUDANWEI
					,ZHENGSHUDANWEI = s.ZHENGSHUDANWEI
					,SONGJIANDANWEI = s.SONGJIANDANWEI
					,SHOULIDANWEI = s.SHOULIDANWEI
					,CHUCHANGRIQI = s.CHUCHANGRIQI
					,QIJUMINGCHENG = s.QIJUMINGCHENG
					,SHENGCHANCHANGJIA = s.SHENGCHANCHANGJIA
					,QIJUXINGHAO = s.QIJUXINGHAO
					,QIJUGUIGE = s.QIJUGUIGE
					,CHUCHANGBIANHAO = s.CHUCHANGBIANHAO
					,SHULIANG = s.SHULIANG
					,SONGJIANRIQI = s.SONGJIANRIQI
					,SONGJIANREN = s.SONGJIANREN
					,JIESHOUREN = s.JIESHOUREN
					,SHIYANSHI = s.SHIYANSHI
					,SHIYANSHIJIESHOUSHIJIAN = s.SHIYANSHIJIESHOUSHIJIAN
					,JIANDINGRIQI = s.JIANDINGRIQI
					,JIANDINGXIAOZHUNYUAN = s.JIANDINGXIAOZHUNYUAN
					,HEYANYUAN = s.HEYANYUAN
					,ZHENGSHUHAOLEIBIE = s.ZHENGSHUHAOLEIBIE
					,ZHENGSHUBAOGAOBIANHAO = s.ZHENGSHUBAOGAOBIANHAO
					,ZHENGSHULEIBIE = s.ZHENGSHULEIBIE
					,BAOGAOLEIBIE = s.BAOGAOLEIBIE
					,SHOUQUANZIZHI = s.SHOUQUANZIZHI
					,QIJUZHUANGTAI = s.QIJUZHUANGTAI
					,YOUXIAOQIZHI = s.YOUXIAOQIZHI
					,BAOGAOSHENPITONGGUORIQI = s.BAOGAOSHENPITONGGUORIQI
					,MOCHONGCHANGSHU = s.MOCHONGCHANGSHU
					,SONGJIANYUEDU = s.SONGJIANYUEDU
					,JIANDINGSHIJIAN = s.JIANDINGSHIJIAN == null ? "0" : ((Convert.ToDateTime(s.JIANDINGRIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString()          
                    ,
                    JIANDINGYUEDU =s.JIANDINGRIQI==null? "0" : Convert.ToDateTime(s.JIANDINGRIQI).Month.ToString()
                    ,
                    BAOGAOSHIJIAN = s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.JIANDINGRIQI)).Days + 1).ToString()
                    ,
                    BAOGAOYUEDU = s.BAOGAOSHENPITONGGUORIQI == null ? "0" : Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI).Month.ToString()
                    ,
                    GONHZUOSHIJIAN = (s.JIANDINGSHIJIAN == null ? "0" : ((Convert.ToDateTime(s.JIANDINGRIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString())!="0"&&(s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.JIANDINGRIQI)).Days + 1).ToString())!="0"? Convert.ToInt32(s.JIANDINGSHIJIAN == null ? "0" : ((Convert.ToDateTime(s.JIANDINGRIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString())+Convert.ToInt32(s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.JIANDINGRIQI)).Days + 1).ToString()):0
                    ,
                    ZONGSHIJIAN = s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString()

                    ,
                    BEIZHU = s.BEIZHU
                        ,
                    TIAOXINGMA = s.TIAOXINGMA

                }

                    )
            });
        }


        /// <summary>
        /// 导出报告
        /// </summary>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        [HttpPost]
        [SupportFilter]
        public ActionResult GetData2(string order, string sort, string search)
        {
            int total = 0;
            List<VBIAOZHUNLIANGCHUANGONGZHUO> queryData = m_BLL.GetByParam(null, 1, 9999, "desc", "ID", search, ref total);

           var rows = queryData.Select(s => new
            {
                ID = s.ID
                  ,
                WEITUODANWEI = s.WEITUODANWEI
                  ,
                SUOSHUDANWEI = s.SUOSHUDANWEI
                  ,
                ZHENGSHUDANWEI = s.ZHENGSHUDANWEI
                  ,
                SONGJIANDANWEI = s.SONGJIANDANWEI
                  ,
                SHOULIDANWEI = s.SHOULIDANWEI
                  ,
                CHUCHANGRIQI = s.CHUCHANGRIQI
                  ,
                QIJUMINGCHENG = s.QIJUMINGCHENG
                  ,
                SHENGCHANCHANGJIA = s.SHENGCHANCHANGJIA
                  ,
                QIJUXINGHAO = s.QIJUXINGHAO
                  ,
                QIJUGUIGE = s.QIJUGUIGE
                  ,
                CHUCHANGBIANHAO = s.CHUCHANGBIANHAO
                  ,
                SHULIANG = s.SHULIANG
                  ,
                SONGJIANRIQI = s.SONGJIANRIQI
                  ,
                SONGJIANREN = s.SONGJIANREN
                  ,
                JIESHOUREN = s.JIESHOUREN
                  ,
                SHIYANSHI = s.SHIYANSHI
                  ,
                SHIYANSHIJIESHOUSHIJIAN = s.SHIYANSHIJIESHOUSHIJIAN
                  ,
                JIANDINGRIQI = s.JIANDINGRIQI
                  ,
                JIANDINGXIAOZHUNYUAN = s.JIANDINGXIAOZHUNYUAN
                  ,
                HEYANYUAN = s.HEYANYUAN
                  ,
                ZHENGSHUHAOLEIBIE = s.ZHENGSHUHAOLEIBIE
                  ,
                ZHENGSHUBAOGAOBIANHAO = s.ZHENGSHUBAOGAOBIANHAO
                  ,
                ZHENGSHULEIBIE = s.ZHENGSHULEIBIE
                  ,
                BAOGAOLEIBIE = s.BAOGAOLEIBIE
                  ,
                SHOUQUANZIZHI = s.SHOUQUANZIZHI
                  ,
                QIJUZHUANGTAI = s.QIJUZHUANGTAI
                  ,
                YOUXIAOQIZHI = s.YOUXIAOQIZHI
                  ,
                BAOGAOSHENPITONGGUORIQI = s.BAOGAOSHENPITONGGUORIQI
                  ,
                MOCHONGCHANGSHU = s.MOCHONGCHANGSHU
                  ,
                SONGJIANYUEDU = s.SONGJIANYUEDU
                  ,
                JIANDINGSHIJIAN = s.JIANDINGSHIJIAN == null ? "0" : ((Convert.ToDateTime(s.JIANDINGRIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString()
                  ,
                JIANDINGYUEDU = s.JIANDINGRIQI == null ? "0" : Convert.ToDateTime(s.JIANDINGRIQI).Month.ToString()
                  ,
                BAOGAOSHIJIAN = s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.JIANDINGRIQI)).Days + 1).ToString()
                  ,
                BAOGAOYUEDU = s.BAOGAOSHENPITONGGUORIQI == null ? "0" : Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI).Month.ToString()
                  ,
                GONHZUOSHIJIAN = (s.JIANDINGSHIJIAN == null ? "0" : ((Convert.ToDateTime(s.JIANDINGRIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString()) != "0" && (s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.JIANDINGRIQI)).Days + 1).ToString()) != "0" ? Convert.ToInt32(s.JIANDINGSHIJIAN == null ? "0" : ((Convert.ToDateTime(s.JIANDINGRIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString()) + Convert.ToInt32(s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.JIANDINGRIQI)).Days + 1).ToString()) : 0
                  ,
                ZONGSHIJIAN = s.BAOGAOSHENPITONGGUORIQI == null ? "0" : ((Convert.ToDateTime(s.BAOGAOSHENPITONGGUORIQI) - Convert.ToDateTime(s.SONGJIANRIQI)).Days + 1).ToString()
                  ,
                BEIZHU = s.BEIZHU
                      ,
                TIAOXINGMA = s.TIAOXINGMA

            }).ToList();

          string[] fields = "WEITUODANWEI,SUOSHUDANWEI,ZHENGSHUDANWEI,SHOULIDANWEI,CHUCHANGRIQI,QIJUMINGCHENG,SHENGCHANCHANGJIA,QIJUXINGHAO,QIJUGUIGE,CHUCHANGBIANHAO,SHULIANG,SONGJIANRIQI,SONGJIANREN,JIESHOUREN,SHIYANSHI,SHIYANSHIJIESHOUSHIJIAN,JIANDINGRIQI,JIANDINGXIAOZHUNYUAN,HEYANYUAN,ZHENGSHUHAOLEIBIE,ZHENGSHUBAOGAOBIANHAO,ZHENGSHULEIBIE,BAOGAOLEIBIE,SHOUQUANZIZHI,QIJUZHUANGTAI,YOUXIAOQIZHI,BAOGAOSHENPITONGGUORIQI,MOCHONGCHANGSHU,SONGJIANYUEDU,JIANDINGSHIJIAN,JIANDINGYUEDU,BAOGAOSHIJIAN,BAOGAOYUEDU,GONHZUOSHIJIAN,ZONGSHIJIAN,BEIZHU".Split(',');
            var a = Content(WriteExcleVBIAOZHUNLIANGCHUANGONGZHUO(fields, rows.ToArray()));
            return a;

        }
        IBLL.IVBIAOZHUNLIANGCHUANGONGZHUOBLL m_BLL;

        ValidationErrors validationErrors = new ValidationErrors();

        public VBIAOZHUNLIANGCHUANGONGZHUOController()
            : this(new VBIAOZHUNLIANGCHUANGONGZHUOBLL()) { }

        public VBIAOZHUNLIANGCHUANGONGZHUOController(VBIAOZHUNLIANGCHUANGONGZHUOBLL bll)
        {
            m_BLL = bll;
        }
      
    }
}


