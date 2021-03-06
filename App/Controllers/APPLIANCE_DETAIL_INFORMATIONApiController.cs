﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;
using Common;
using Langben.DAL;
using Langben.BLL;
using System.Web.Http;
using Langben.App.Models;

namespace Langben.App.Controllers
{
    /// <summary>
    /// 器具明细信息
    /// </summary>
    public class APPLIANCE_DETAIL_INFORMATIONApiController : BaseApiController
    {
        /// <summary>
        /// 异步加载数据
        /// </summary>
        /// <param name="getParam"></param>
        /// <returns></returns>
        /// 
        #region
        //[HttpPost]
        //public Common.ClientResult.DataResult PostDataByID(string id)
        //{

        //    if (!string.IsNullOrWhiteSpace(id))
        //    {

        //        id = id.Replace("@", "&");
        //    }
        //    int total = 0;
        //    string UNDERTAKE_LABORATORYID = string.Empty;
        //    List<APPLIANCE_DETAIL_INFORMATION> queryData = m_BLL.GetByParam(null, 1, 1, "DESC", "ID", id, ref total);
        //    foreach (var item in queryData)
        //    {
        //        List<APPLIANCE_LABORATORY> list = m_BLL2.GetByRefAPPLIANCE_DETAIL_INFORMATIOID(item.ID);
        //        foreach (var item2 in list)
        //        {
        //            UNDERTAKE_LABORATORYID += item2.UNDERTAKE_LABORATORYID + ",";
        //        }
        //    }
        //    var data = new Common.ClientResult.DataResult
        //    {
        //        total = total,
        //        rows = queryData.Select(s => new APPLIANCE_DETAIL_INFORMATIONShow
        //        {
        //            ID = s.ID
        //            ,
        //            BAR_CODE_NUM = s.BAR_CODE_NUM
        //            ,
        //            APPLIANCE_NAME = s.APPLIANCE_NAME
        //            ,
        //            //VERSION = s.VERSION,
        //            FORMAT = s.FORMAT
        //            ,
        //            FACTORY_NUM = s.FACTORY_NUM
        //            ,
        //            NUM = s.NUM
        //            ,
        //            ATTACHMENT = s.ATTACHMENT
        //            ,
        //            APPEARANCE_STATUS = s.APPEARANCE_STATUS
        //            ,
        //            MAKE_ORGANIZATION = s.MAKE_ORGANIZATION
        //            ,
        //            REMARKS = s.REMARKS
        //            ,
        //            END_PLAN_DATE = s.END_PLAN_DATE
        //            ,
        //            ORDER_TASK_INFORMATION =new ORDER_TASK_INFORMATIONShow() {
        //                ID = s.ORDER_TASK_INFORMATION.ID
        //            ,
        //                ORDER_NUMBER = s.ORDER_TASK_INFORMATION.ORDER_NUMBER
        //            ,
        //                ACCEPT_ORGNIZATION = s.ORDER_TASK_INFORMATION.ACCEPT_ORGNIZATION
        //            ,
        //                INSPECTION_ENTERPRISE = s.ORDER_TASK_INFORMATION.INSPECTION_ENTERPRISE
        //            ,
        //                INSPECTION_ENTERPRISE_ADDRESS = s.ORDER_TASK_INFORMATION.INSPECTION_ENTERPRISE_ADDRESS
        //            ,
        //                INSPECTION_ENTERPRISE_POST = s.ORDER_TASK_INFORMATION.INSPECTION_ENTERPRISE_POST
        //            ,
        //                CONTACTS = s.ORDER_TASK_INFORMATION.CONTACTS
        //            ,
        //                CONTACT_PHONE = s.ORDER_TASK_INFORMATION.CONTACT_PHONE
        //            ,
        //                FAX = s.ORDER_TASK_INFORMATION.FAX
        //            ,
        //                CERTIFICATE_ENTERPRISE = s.ORDER_TASK_INFORMATION.CERTIFICATE_ENTERPRISE
        //            ,
        //                CERTIFICATE_ENTERPRISE_ADDRESS = s.ORDER_TASK_INFORMATION.CERTIFICATE_ENTERPRISE_ADDRESS
        //            ,
        //                CERTIFICATE_ENTERPRISE_POST = s.ORDER_TASK_INFORMATION.CERTIFICATE_ENTERPRISE_POST
        //            ,
        //                CONTACTS2 = s.ORDER_TASK_INFORMATION.CONTACTS2
        //            ,
        //                CONTACT_PHONE2 = s.ORDER_TASK_INFORMATION.CONTACT_PHONE2
        //            ,
        //                FAX2 = s.ORDER_TASK_INFORMATION.FAX2
        //            ,
        //                CUSTOMER_SPECIFIC_REQUIREMENTS = s.ORDER_TASK_INFORMATION.CUSTOMER_SPECIFIC_REQUIREMENTS
        //            ,
        //                ORDER_STATUS = s.ORDER_TASK_INFORMATION.ORDER_STATUS
        //            ,
        //                CREATETIME = s.ORDER_TASK_INFORMATION.CREATETIME
        //            ,
        //                CREATEPERSON = s.ORDER_TASK_INFORMATION.CREATEPERSON
        //            ,
        //                UPDATETIME = s.ORDER_TASK_INFORMATION.UPDATETIME
        //            ,
        //                UPDATEPERSON = s.ORDER_TASK_INFORMATION.UPDATEPERSON
        //            }
        //            ,
        //            CREATETIME = s.CREATETIME
        //            ,
        //            CREATEPERSON = s.CREATEPERSON
        //            ,
        //            UPDATETIME = s.UPDATETIME
        //            ,
        //            UPDATEPERSON = s.UPDATEPERSON
        //            ,
        //            APPLIANCE_RECIVE = s.APPLIANCE_RECIVE
        //            ,
        //            APPLIANCE_PROGRESS = s.APPLIANCE_PROGRESS
        //            ,
        //            ORDER_STATUS = s.ORDER_STATUS
        //            ,
        //            ISOVERDUE = s.ISOVERDUE
        //            ,
        //            OVERDUE = s.OVERDUE
        //            ,
        //            STORAGEINSTRUCTIONS = s.STORAGEINSTRUCTIONS
        //            ,
        //            STORAGEINSTRUCTI_STATU = s.STORAGEINSTRUCTI_STATU,
        //            VERSION = s.VERSION,

        //            UNDERTAKE_LABORATORYIDString = UNDERTAKE_LABORATORYID
        //        })

        //    };
        //    return data;
        //}
        #endregion
        [HttpPost]
        public Common.ClientResult.DataResult PostData([FromBody]GetDataParam getParam)
        {
            int total = 0;
            List<APPLIANCE_DETAIL_INFORMATION> queryData = m_BLL.GetByParam(null, getParam.page, getParam.rows, getParam.order, getParam.sort, getParam.search, ref total);
            var data = new Common.ClientResult.DataResult
            {
                total = total,
                rows = queryData.Select(s => new
                {
                    ID = s.ID
                    ,
                    BAR_CODE_NUM = s.BAR_CODE_NUM
                    ,
                    APPLIANCE_NAME = s.APPLIANCE_NAME
                    ,
                    MODEL = s.VERSION,
                    FORMAT = s.FORMAT
                    ,
                    FACTORY_NUM = s.FACTORY_NUM
                    ,
                    NUM = s.NUM
                    ,
                    ATTACHMENT = s.ATTACHMENT
                    ,
                    APPEARANCE_STATUS = s.APPEARANCE_STATUS
                    ,
                    MAKE_ORGANIZATION = s.MAKE_ORGANIZATION
                    ,
                    REMARKS = s.REMARKS
                    ,
                    END_PLAN_DATE = s.END_PLAN_DATE
                    ,
                    ORDER_TASK_INFORMATIONID = s.ORDER_TASK_INFORMATIONIDOld
                    ,
                    CREATETIME = s.CREATETIME
                    ,
                    CREATEPERSON = s.CREATEPERSON
                    ,
                    UPDATETIME = s.UPDATETIME
                    ,
                    UPDATEPERSON = s.UPDATEPERSON
                    ,
                    APPLIANCE_RECIVE = s.APPLIANCE_RECIVE
                    ,
                    APPLIANCE_PROGRESS = s.APPLIANCE_PROGRESS
                    ,
                    ISOVERDUE = s.ISOVERDUE
                    ,
                    OVERDUE = s.OVERDUE
                    ,
                    STORAGEINSTRUCTIONS = s.STORAGEINSTRUCTIONS
                    ,
                    STORAGEINSTRUCTI_STATU = s.STORAGEINSTRUCTI_STATU


                })
            };
            return data;
        }

        /// <summary>
        /// 根据ID获取数据模型
        /// </summary>
        /// <param name="id">编号</param>
        /// <returns></returns>
        public APPLIANCE_DETAIL_INFORMATION Get(string id)
        {
            APPLIANCE_DETAIL_INFORMATION item = m_BLL.GetById(id);
            return item;
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public Common.ClientResult.Result Post([FromBody]APPLIANCE_DETAIL_INFORMATION entity)
        {

            Common.ClientResult.Result result = new Common.ClientResult.Result();
            if (entity != null && ModelState.IsValid)
            {
                string currentPerson = GetCurrentPerson();
                entity.CREATETIME = DateTime.Now;
                entity.CREATEPERSON = currentPerson;

                entity.ID = Result.GetNewId();
                string returnValue = string.Empty;
                if (m_BLL.Create(ref validationErrors, entity))
                {
                    LogClassModels.WriteServiceLog(Suggestion.InsertSucceed + "，器具明细信息的信息的Id为" + entity.ID, "器具明细信息"
                        );//写入日志 
                    result.Code = Common.ClientCode.Succeed;
                    result.Message = Suggestion.InsertSucceed;
                    return result; //提示创建成功
                }
                else
                {
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        validationErrors.All(a =>
                        {
                            returnValue += a.ErrorMessage;
                            return true;
                        });
                    }
                    LogClassModels.WriteServiceLog(Suggestion.InsertFail + "，器具明细信息的信息，" + returnValue, "器具明细信息"
                        );//写入日志                      
                    result.Code = Common.ClientCode.Fail;
                    result.Message = Suggestion.InsertFail + returnValue;
                    return result; //提示插入失败
                }
            }

            result.Code = Common.ClientCode.FindNull;
            result.Message = Suggestion.InsertFail + "，请核对输入的数据的格式"; //提示输入的数据的格式不对 
            return result;
        }

        // PUT api/<controller>/5
        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>  
        /// 
        [HttpPut]
        public Common.ClientResult.Result Put([FromBody]APPLIANCE_DETAIL_INFORMATION entity)
        {
            Common.ClientResult.Result result = new Common.ClientResult.Result();
            if (entity != null && ModelState.IsValid)
            {   //数据校验

                string currentPerson = GetCurrentPerson();
                entity.UPDATETIME = DateTime.Now;
                entity.UPDATEPERSON = currentPerson;

                string returnValue = string.Empty;
                if (m_BLL.Edit(ref validationErrors, entity))
                {
                    LogClassModels.WriteServiceLog(Suggestion.UpdateSucceed + "，器具明细信息信息的Id为" + entity.ID, "器具明细信息"
                        );//写入日志                   
                    result.Code = Common.ClientCode.Succeed;
                    result.Message = Suggestion.UpdateSucceed;
                    return result; //提示更新成功 
                }
                else
                {
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        validationErrors.All(a =>
                        {
                            returnValue += a.ErrorMessage;
                            return true;
                        });
                    }
                    LogClassModels.WriteServiceLog(Suggestion.UpdateFail + "，器具明细信息信息的Id为" + entity.ID + "," + returnValue, "器具明细信息"
                        );//写入日志   
                    result.Code = Common.ClientCode.Fail;
                    result.Message = Suggestion.UpdateFail + returnValue;
                    return result; //提示更新失败
                }
            }
            result.Code = Common.ClientCode.FindNull;
            result.Message = Suggestion.UpdateFail + "请核对输入的数据的格式";
            return result; //提示输入的数据的格式不对         
        }

        // DELETE api/<controller>/5
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>  
        public Common.ClientResult.Result Delete(string id)
        {
            Common.ClientResult.Result result = new Common.ClientResult.Result();

            string returnValue = string.Empty;
            string[] deleteId = id.GetString().Split(',');
            if (deleteId != null && deleteId.Length > 0)
            {
                if (m_BLL.DeleteCollection(ref validationErrors, deleteId))
                {
                    LogClassModels.WriteServiceLog(Suggestion.DeleteSucceed + "，信息的Id为" + string.Join(",", deleteId), "消息"
                        );//删除成功，写入日志
                    result.Code = Common.ClientCode.Succeed;
                    result.Message = Suggestion.DeleteSucceed;
                }
                else
                {
                    if (validationErrors != null && validationErrors.Count > 0)
                    {
                        validationErrors.All(a =>
                        {
                            returnValue += a.ErrorMessage;
                            return true;
                        });
                    }
                    LogClassModels.WriteServiceLog(Suggestion.DeleteFail + "，信息的Id为" + string.Join(",", deleteId) + "," + returnValue, "消息"
                        );//删除失败，写入日志
                    result.Code = Common.ClientCode.Fail;
                    result.Message = Suggestion.DeleteFail + returnValue;
                }
            }
            return result;
        }



        IBLL.IAPPLIANCE_DETAIL_INFORMATIONBLL m_BLL;
        IBLL.IAPPLIANCE_LABORATORYBLL m_BLL2;

        ValidationErrors validationErrors = new ValidationErrors();

        public APPLIANCE_DETAIL_INFORMATIONApiController()
            : this(new APPLIANCE_DETAIL_INFORMATIONBLL(), new APPLIANCE_LABORATORYBLL()) { }

        public APPLIANCE_DETAIL_INFORMATIONApiController(APPLIANCE_DETAIL_INFORMATIONBLL bll, APPLIANCE_LABORATORYBLL bll2)
        {
            m_BLL = bll;
            m_BLL2 = bll2;
        }

    }
}


