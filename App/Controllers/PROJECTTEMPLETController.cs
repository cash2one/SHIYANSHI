﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Text;
using System.EnterpriseServices;
using System.Configuration;
using Models;
using Common;
using Langben.DAL;
using Langben.BLL;
using Langben.App.Models;

namespace Langben.App.Controllers
{
    /// <summary>
    /// 检定项目模板
    /// </summary>
    public class PROJECTTEMPLETController : BaseController
    {//
     /// <summary>
     ///位置影响
     /// </summary>
     /// <param name="id">canshu</param>
     /// <param name="RULEID">规程id</param>
     /// <param name="SCHEMEID">方案id</param>
     /// <param name="PREPARE_SCHEMEID">预备方案id</param>
     /// <returns></returns>
        public ActionResult WeiZhiYingXiang(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///电子式辅助电阻影响
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DianZiShiFuZhuDianZuYingXiang(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///三相连接组别
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DianYaHuGanQiCeLiangHuiLu(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        ///三相连接组别
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult SanXiangLianJieZuBie(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///指针式辅助电阻影响
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult ZhiZhenShiFuZhuDianZuYingXiang(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///探头
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult TanTou(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///误差测试
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult BiaoZhunPianCha(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///误差测试
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult WuChaCeShi(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///钳形表
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult QianXingBiao(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///定值电阻-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult BianBiCeShi(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///定值电阻-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DingZhiDianZuXiangDuiWuCha(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        ///24h变差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DianYaBiaoShiZhiWuCha(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }


        /// <summary>
        ///24h变差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult BianCha(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///电能标准偏差估计值
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DianNengBiaoZhunPianChaGuJiZhi(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        ///单桥-其他量程-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DanQiaoQiTaLiangCheng(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///标准电阻箱-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult BiaoZhunDianZuXiang(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        ///1000Ω以上-无误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult OMYiShangWuWuCha(  string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
             
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 1000Ω以下-标准电阻-相对误差-无型号编号
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult OMYiXiaBiaoZhunDianZu( string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
             
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 基本误差-电阻示值-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DanQiaoJiBenLiangCheng(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 基本误差-电阻示值-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult JiBenWuChaDianZuShiZhi(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 1000Ω以下-无误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult OMYiXiaWuWuCha(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 绝缘电阻-无误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult JueYuanDianZu(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 工作电流示值误差-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult GongZuoDianLiuShiZhiWuCha(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
             
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 电阻示值误差-相对误差
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult DianZuShiZhiWuCha(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
             
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 交流电流输出-相对误差-单相
        /// </summary>
        /// <param name="id">canshu</param>
        /// <param name="RULEID">规程id</param>
        /// <param name="SCHEMEID">方案id</param>
        /// <param name="PREPARE_SCHEMEID">预备方案id</param>
        /// <returns></returns>
        public ActionResult JiaoLiuDianLiuShuChuDanxiang(string id = "相对误差", string RULEID = "34-1999_3_2", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            //相对误差 410-1994_6_5           

            //绝对误差 410 - 1994_6_6
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /**************上面是单相实验室的********************/
        /// <summary>
        /// 测试用
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult test(string id = "频率输出", string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            //频率输出
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 有功功率输出（测量）-引用误差
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult YouGongGongLvShuChuYinYongWuCha(string id = "三相四线", string RULEID = "JJG126-1995_5", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //三相四线
            //三相三线
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 变送器-有功（无功）功率-引用误差
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult BianSongQiYouGongWuGong(string id = "有功功率", string RULEID = "126-1995_2_4_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 变送器-相位-引用误差
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult BianSongQiXiangWei(string RULEID = "126-1995_2_7_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 变送器-频率-引用误差
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult BianSongQiPinLu(string RULEID = "126-1995_2_1_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 变送器-功率-引用误差
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult BianSongQiGongLu(string RULEID = "126-1995_2_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }


        /// <summary>
        /// 变送器-电流电压-引用误差 BianSongQiDianLiuDianYa/电流
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult BianSongQiDianLiuDianYa(string id = "电流", string RULEID = "126-1995_2_3_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }


        /// <summary>
        /// 工频单相相位输出（测量）-绝对误差-一列
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult GongPinDanXiangXiangWeiShuChuJueDuiWuChaYiLie(string id = "1", string ceLiangShuChu = "相位输出", string RULEID = "test", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //url中的配置需要加&ceLiangShuChu=相位测量
            //url中的配置需要加&ceLiangShuChu=相位输出

            ViewBag.ceLiangShuChu = ceLiangShuChu;
            ViewBag.canshu = Convert.ToInt32(id);
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 直流电压（电流）测量-非正负极性-相对误差
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult ZhiLiuDianLiuDianYaFeiZhengFu(string id = "电压输出", string RULEID = "445-1986_2_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //电压输出
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }
        /// <summary>
        /// 直流电压（电流）测量-非正负极性-绝对误差
        /// http://localhost:55977/PROJECTTEMPLET/ZhiLiuDianLiuDianYaFeiZhengFuJueDuiWuCha/%E6%B5%8B%E9%87%8F?wucha=%E7%9B%B8%E5%AF%B9%E8%AF%AF%E5%B7%AE
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult ZhiLiuDianLiuDianYaFeiZhengFuJueDuiWuChaLiangCheng(string id = "输出", string wucha = "绝对误差", string RULEID = "315-1983_2_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //输出 测量
            ViewBag.canshu =id;
            //绝对误差 相对误差 
            ViewBag.wucha = wucha;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 直流电压（电流）测量-非正负极性-绝对误差
        /// http://localhost:55977/PROJECTTEMPLET/ZhiLiuDianLiuDianYaFeiZhengFuJueDuiWuCha/%E6%B5%8B%E9%87%8F?wucha=%E7%9B%B8%E5%AF%B9%E8%AF%AF%E5%B7%AE
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult ZhiLiuDianLiuDianYaFeiZhengFuJueDuiWuCha(string id = "输出", string wucha = "绝对误差", string RULEID = "315-1983_2_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //输出 测量
            ViewBag.canshu = id;
            //绝对误差 相对误差 
            ViewBag.wucha = wucha;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 直流电压（电流）测量-正负极性-相对误差（多通道）
        /// </summary> 
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <returns></returns>
        public ActionResult ZhiLiuDianLiuDianYaZhengFu(string id = "相对误差", string RULEID = "315-1983_2_2", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //相对误差 绝对误差
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 直流电流输出
        /// </summary>
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <returns></returns> 
        [SupportFilter]
        public ActionResult ZhiLiuDianLiuShuChu(string id = "相对误差", string RULEID = "445-1986_2_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //相对误差 绝对误差
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 交流电压（电流）-相对误差-两相
        /// </summary>
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <returns></returns> 
        [SupportFilter]
        public ActionResult JiaoLiuDianYaXiangDuiWuChaLiangXiang(string id = "电压输出", string RULEID = "410-1994_6_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {

            //电压输出 电压测量 电流测量 电流输出
            //JiaoLiuDianYaXiangDuiWuChaSanXiang / 电压输出
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 交流电压(电流)-相对误差-三相
        /// </summary>
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <returns></returns> 
        [SupportFilter]
        public ActionResult JiaoLiuDianYaXiangDuiWuChaSanXiang(string id = "电压输出", string RULEID = "35-1999_3_6", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //电压输出 电压测量 电流测量 电流输出
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 交流电压（电流）测量-相对误差-单相(多通道）34-1999_3_1
        /// </summary>
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <returns></returns> 
        [SupportFilter]
        public ActionResult JiaoLiuDianYaXiangDuiWuChaDanxiang(string id = "输出", string wucha = "相对误差",  string RULEID = "34-1999_3_2", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
                   

            //绝对误差 410 - 1994_6_6//相对误差 410-1994_6_5    
            ViewBag.wucha = wucha;

            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        /// <summary>
        /// 频率输出-频率测量-相对误差
        /// </summary>
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="SCHEMEID">方案ID</param>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <returns></returns> 
        [SupportFilter]
        public ActionResult PingLuShuChuCheLinagXiangDuiWuCha(string id = "频率输出", string RULEID = "603-2006_3_2_1", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            //localhost:55977/PROJECTTEMPLET/PingLuShuChuCheLinagXiangDuiWuCha/频率输出   //603-2006_3_2_1
            //localhost:55977/PROJECTTEMPLET/PingLuShuChuCheLinagXiangDuiWuCha/频率测量
            ViewBag.canshu = id;
            return Detail(RULEID, SCHEMEID, PREPARE_SCHEMEID);
        }

        public ActionResult Detail(string RULEID = "", string SCHEMEID = "", string PREPARE_SCHEMEID = "")
        {
            if (!string.IsNullOrWhiteSpace(PREPARE_SCHEMEID))
            {//预备方案
                QUALIFIED_UNQUALIFIED_TEST_ITE qEntity = null;
                IBLL.IQUALIFIED_UNQUALIFIED_TEST_ITEBLL qBLL = new QUALIFIED_UNQUALIFIED_TEST_ITEBLL();
                qEntity = qBLL.GetByPREPARE_SCHEMEID_RULEID(PREPARE_SCHEMEID, RULEID);
                if (qEntity != null)
                {
                    ViewBag.HTMLVALUE = qEntity.HTMLVALUE;
                    ViewBag.ITEID = qEntity.ID;
                }
                else
                {
                    PREPARE_SCHEME pEntity = new DAL.PREPARE_SCHEME();
                    IBLL.IPREPARE_SCHEMEBLL pBLL = new BLL.PREPARE_SCHEMEBLL();
                    pEntity = pBLL.GetById(PREPARE_SCHEMEID);
                    if(pEntity!=null)
                    {
                        SCHEMEID = pEntity.SCHEMEID;
                    }
                    //方案
                    DAL.PROJECTTEMPLET entity = m_BLL.GetModelByRULEID_SCHEMEID(RULEID, SCHEMEID);
                    if (entity != null)
                    {
                        ViewBag.ID = entity.ID;
                        ViewBag.HTMLVALUE = entity.HTMLVALUE;
                    }
                    else
                    {
                        ViewBag.ID = string.Empty;
                    }

                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(SCHEMEID))
                {
                    //方案
                    DAL.PROJECTTEMPLET entity = m_BLL.GetModelByRULEID_SCHEMEID(RULEID, SCHEMEID);
                    if (entity != null)
                    {
                        ViewBag.ID = entity.ID;
                        ViewBag.HTMLVALUE = entity.HTMLVALUE;
                    }
                    else
                    {
                        ViewBag.ID = string.Empty;
                    }
                }
            }

            ViewBag.PREPARE_SCHEMEID = PREPARE_SCHEMEID;
            ViewBag.RULEID = RULEID;
            ViewBag.SCHEMEID = SCHEMEID;
            return View();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="OldID">原编号</param>
        /// <param name="RULEID">规程编号</param>
        /// <param name="SCHEMEID">方案编号</param>
        /// <param name="HTMLVALUE">html</param>
        /// <returns></returns>
        public ActionResult Save(string OldID, string RULEID, string SCHEMEID, string HTMLVALUE)
        {
            Common.ClientResult.Result result = new Common.ClientResult.Result();
            PROJECTTEMPLET entity = new PROJECTTEMPLET();
            string currentPerson = GetCurrentPerson();
            entity.CREATETIME = DateTime.Now;
            entity.CREATEPERSON = currentPerson;
            entity.RULEID = RULEID;
            entity.ID = Result.GetNewId();
            entity.SCHEMEID = SCHEMEID;
            entity.HTMLVALUE = Server.UrlDecode(HTMLVALUE);//解码

            if (OldID != null && OldID.Trim() != "")
            {
                m_BLL.Delete(ref validationErrors, OldID);
            }

            string returnValue = string.Empty;
            if (m_BLL.Create(ref validationErrors, entity))
            {
                LogClassModels.WriteServiceLog(Suggestion.InsertSucceed + "，检定项目模板的Id为" + entity.ID, "检定项目模板"
                    );//写入日志 
                result.Code = Common.ClientCode.Succeed;
                //result.Message = Suggestion.InsertSucceed;
                result.Message = entity.ID;
                return Json(result); //提示创建成功
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
                LogClassModels.WriteServiceLog(Suggestion.InsertFail + "，检定项目模板，" + returnValue, "检定项目模板"
                    );//写入日志                      
                result.Code = Common.ClientCode.Fail;
                result.Message = Suggestion.InsertFail + returnValue;
                return Json(result); //提示插入失败
            }

        }
        /// <summary>
        /// 计算不确定度页
        /// </summary>
        /// <param name="ID">控件ID</param>
        /// <param name="RULEID">检测项目ID</param>
        /// <param name="PREPARE_SCHEMEID">预备方案ID</param>
        /// <returns></returns>
        public ActionResult JiSuanBuQueDingDu(string ID = "", string RULEID = "",string PREPARE_SCHEMEID = "",string URL="")
        {
            Common.Account account = GetCurrentAccount();
            if (string.IsNullOrWhiteSpace(URL) || URL.Trim() == "")
            {
                URL = GetBuQueDingDuUrl(URL);
            }
            string htmlValue = "";
            if(DirFile.FileExists(URL))
            {
                htmlValue = DirFile.ReadFile(URL);
            }
            ViewBag.ID = ID;
            ViewBag.RULEID = RULEID;            
            ViewBag.HTMLVALUE = htmlValue;
            ViewBag.PREPARE_SCHEMEID = PREPARE_SCHEMEID;
            ViewBag.URL = URL;
            ViewBag.UNDERTAKE_LABORATORY_NAME = account.UNDERTAKE_LABORATORYName;
            return View();
        }
        /// <summary>
        /// 保存不确定度
        /// </summary>        
        /// <param name="HTMLVALUE">html</param>
        /// <param name="URL">不确定计算存储地址</param>
        /// <returns></returns>
        public ActionResult JiSuanBuQueDingDuSave(string HTMLVALUE="",string URL="")
        {
            Common.ClientResult.Result result = new Common.ClientResult.Result();
            try
            {
                URL = GetBuQueDingDuUrl(URL);
                if (DirFile.FileExists(URL))
                {
                    DirFile.DeleteFile(URL);
                }
                HTMLVALUE = Server.UrlDecode(HTMLVALUE);//解码
                DirFile.SaveFile(HTMLVALUE, URL);
                LogClassModels.WriteServiceLog(Suggestion.InsertSucceed + Url, "不确定度计算");//写入日志 
                result.Code = Common.ClientCode.Succeed;               
                result.Message = URL;
                return Json(result); //提示创建成功
            }
            catch(Exception ex)
            {
                LogClassModels.WriteServiceLog(Suggestion.InsertFail + Url+":"+ex.Message,"不确定度计算");//写入日志                      
                result.Code = Common.ClientCode.Fail;
                result.Message = Suggestion.InsertFail + ex.Message;
                return Json(result); //提示插入失败
            }       
           

        }
        /// <summary>
        /// 获取不确定路径
        /// </summary>       
        /// <param name="RULEID">检测项目ID</param>        
        /// <returns></returns>
        private string GetBuQueDingDuUrl(string URL)
        {          
            
            string htmlValue = "";
            if (!string.IsNullOrWhiteSpace(URL) && DirFile.FileExists(URL))
            {
                htmlValue = DirFile.ReadFile(URL);
            }
            else
            {
               URL = "/up/BuQueDingDu/"+Result.GetNewId()+".html";
            }
            return URL;
        }

        IBLL.IPROJECTTEMPLETBLL m_BLL;
        ValidationErrors validationErrors = new ValidationErrors();
        public PROJECTTEMPLETController()
                    : this(new PROJECTTEMPLETBLL()) { }

        public PROJECTTEMPLETController(PROJECTTEMPLETBLL bll)
        {
            m_BLL = bll;
        }


        //public ActionResult BuQueDingDu()
       // {
        //    return View();
        //}
        public ActionResult GongZuoDianLiuShiZhiWuCha9()
        {

            return View();
        }
    }
}


