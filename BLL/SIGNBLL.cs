﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
using Langben.DAL;
using Common;

namespace Langben.BLL
{
    /// <summary>
    /// 委托单签字 
    /// </summary>
    public partial class SIGNBLL :  IBLL.ISIGNBLL, IDisposable
    {
        /// <summary>
        /// 私有的数据访问上下文
        /// </summary>
        protected SysEntities db;
        /// <summary>
        /// 委托单签字的数据库访问对象
        /// </summary>
        SIGNRepository repository = new SIGNRepository();
        /// <summary>
        /// 构造函数，默认加载数据访问上下文
        /// </summary>
        public SIGNBLL()
        {
            db = new SysEntities();
        }
        /// <summary>
        /// 已有数据访问上下文的方法中调用
        /// </summary>
        /// <param name="entities">数据访问上下文</param>
        public SIGNBLL(SysEntities entities)
        {
            db = entities;
        }
        /// <summary>
        /// 查询的数据
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        public List<SIGN> GetByParam(string id, int page, int rows, string order, string sort, string search, ref int total)
        {
            using (SysEntities db = new SysEntities())
            {

                return (db.SIGN.Where(w=>w.UPDATEPERSON== search)).ToList();
            }
             
        }
        /// <summary>
        /// 查询的数据 /*在6.0版本中 新增*/
        /// </summary>
        /// <param name="id">额外的参数</param>
        /// <param name="page">页码</param>
        /// <param name="rows">每页显示的行数</param>
        /// <param name="order">排序字段</param>
        /// <param name="sort">升序asc（默认）还是降序desc</param>
        /// <param name="search">查询条件</param>
        /// <param name="total">结果集的总数</param>
        /// <returns>结果集</returns>
        public List<SIGN> GetByParam(string id, string order, string sort, string search)
        {
            IQueryable<SIGN> queryData = repository.GetData(db, order, sort, search);
            
            return queryData.ToList();
        }
        /// <summary>
        /// 创建一个委托单签字
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">一个委托单签字</param>
        /// <returns></returns>
        public bool Create(ref ValidationErrors validationErrors, SIGN entity)
        {
            try
            {
                repository.Create(entity);
                return true;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        ///  创建委托单签字集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entitys">委托单签字集合</param>
        /// <returns></returns>
        public bool CreateCollection(ref ValidationErrors validationErrors, IQueryable<SIGN> entitys)
        {
            try
            {
                if (entitys != null)
                {
                    int count = entitys.Count();
                    if (count == 1)
                    {
                        return this.Create(ref validationErrors, entitys.FirstOrDefault());
                    }
                    else if (count > 1)
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            repository.Create(db, entitys);
                            if (count == repository.Save(db))
                            {
                                transactionScope.Complete();
                                return true;
                            }
                            else
                            {
                                Transaction.Current.Rollback();
                            }                          
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        /// 删除一个委托单签字
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="id">一委托单签字的主键</param>
        /// <returns></returns>  
        public bool Delete(ref ValidationErrors validationErrors, string id)
        {
            try
            {
                return repository.Delete(id) == 1;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        /// 删除委托单签字集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="deleteCollection">委托单签字的集合</param>
        /// <returns></returns>    
        public bool DeleteCollection(ref ValidationErrors validationErrors, string[] deleteCollection)
        {
            try
            {
                if (deleteCollection != null)
                { 
                        using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            repository.Delete(db, deleteCollection);
                            if (deleteCollection.Length == repository.Save(db))
                            {
                                transactionScope.Complete();
                                return true;
                            }
                            else
                            {
                                Transaction.Current.Rollback();
                            }
                        }
                    }
             
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
        /// <summary>
        ///  创建委托单签字集合
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entitys">委托单签字集合</param>
        /// <returns></returns>
        public bool EditCollection(ref ValidationErrors validationErrors, IQueryable<SIGN> entitys)
        {
            try
            {
                if (entitys != null)
                {
                    int count = entitys.Count();
                    if (count == 1)
                    {
                        return this.Edit(ref validationErrors, entitys.FirstOrDefault());
                    }
                    else if (count > 1)
                    {
                        using (TransactionScope transactionScope = new TransactionScope())
                        { 
                            repository.Edit(db, entitys);
                            if (count == repository.Save(db))
                            {
                                transactionScope.Complete();
                                return true;
                            }
                            else
                            {
                                Transaction.Current.Rollback();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
         /// <summary>
        /// 编辑一个委托单签字
        /// </summary>
        /// <param name="validationErrors">返回的错误信息</param>
        /// <param name="entity">一个委托单签字</param>
        /// <returns></returns>
        public bool Edit(ref ValidationErrors validationErrors, SIGN entity)
        {
            try
            { 
                repository.Edit(db, entity);
                repository.Save(db);
                return true;
            }
            catch (Exception ex)
            {
                validationErrors.Add(ex.Message);
                ExceptionsHander.WriteExceptions(ex);                
            }
            return false;
        }
      
        public List<SIGN> GetAll()
        {           
            return repository.GetAll(db).ToList();          
        }   
        
        /// <summary>
        /// 根据主键获取一个委托单签字
        /// </summary>
        /// <param name="id">委托单签字的主键</param>
        /// <returns>一个委托单签字</returns>
        public SIGN GetById(string id)
        {           
            return repository.GetById(db, id);           
        }


        /// <summary>
        /// 根据ORDER_TASK_INFORMATIONIDId，获取所有委托单签字数据
        /// </summary>
        /// <param name="id">外键的主键</param>
        /// <returns></returns>
        public List<SIGN> GetByRefORDER_TASK_INFORMATIONID(string id)
        {
            return repository.GetByRefORDER_TASK_INFORMATIONID(db, id).ToList();                      
        }

        public void Dispose()
        {
           
        }
    }
}

