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
    /// 入库
    /// </summary>
    public class VRUKUController : BaseController
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
        /// <param name="order">升序asc（默认）还是降序desc</param>
        /// <param name="sort">排序字段</param>
        /// <param name="search">查询条件</param>
        /// <returns></returns>
        [HttpPost]
        [SupportFilter]
        public JsonResult GetData(string id, int page, int rows, string order, string sort, string search)
        {

            int total = 0;
            List<VRUKU> queryData = m_BLL.GetByParam(id, page, rows, order, sort, search, ref total);
            return Json(new datagrid
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
                    ,
                    REPORTNUMBER = s.REPORTNUMBER
                    ,
                    ORDER_NUMBER = s.ORDER_NUMBER
                    ,
                    APPLIANCE_NAME = s.APPLIANCE_NAME
                    ,
                    VERSION = s.VERSION
                    ,
                    FACTORY_NUM = s.FACTORY_NUM
                    ,
                    CERTIFICATE_ENTERPRISE = s.CERTIFICATE_ENTERPRISE
                    ,
                    CUSTOMER_SPECIFIC_REQUIREMENTS = s.CUSTOMER_SPECIFIC_REQUIREMENTS
                    ,
                    NAME = s.NAME
                    ,
                    ORDER_STATUS = s.ORDER_STATUS
                    ,
                    STORAGEINSTRUCTIONS = s.STORAGEINSTRUCTIONS
                    ,
                    UNDERTAKE_LABORATORYID = s.UNDERTAKE_LABORATORYID
                    ,
                    APPROVALDATE = s.APPROVALDATE
                    ,
                    STORAGEINSTRUCTI_STATU = s.STORAGEINSTRUCTI_STATU

                }

                    )
            });
        }


        IBLL.IVRUKUBLL m_BLL;

        ValidationErrors validationErrors = new ValidationErrors();

        public VRUKUController()
            : this(new VRUKUBLL()) { }

        public VRUKUController(VRUKUBLL bll)
        {
            m_BLL = bll;
        }

    }
}

