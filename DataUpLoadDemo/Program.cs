using APDataUpLoadDemoI.Entity;
using DataUpLoadDemo.Common;
using DataUpLoadDemo.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUpLoadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取公司编号
            string companyid = (AppSettingsConfig.CompanyId);
            //获取令牌
            var tokenResult = WebApiHelper.GetSignToken(companyid);
            //本地输出令牌信息
            Console.WriteLine(tokenResult.ToString());

            //每个监测点的多个指标
            data data1 = new data() { tagid = "S01-Rtd", tagname = "XXX", tagdata = "12.21", tagstate = "00" };
            data data2 = new data() { tagid = "S02-Rtd", tagname = "XXX", tagdata = "13.21", tagstate = "00" };
            data data3 = new data() { tagid = "S03-Rtd", tagname = "XXX", tagdata = "112.21", tagstate = "00" };
            data data4 = new data() { tagid = "S04-Rtd", tagname = "XXX", tagdata = "133.21", tagstate = "00" };

            //一个监测点的监测数据
            //equipmentcode为设备编号，需要提前与长勘院联系，录入数据库
            //surveytypecode请参考下发的数据接入标准
            monitordata monitordatamodel = new monitordata() { companyid = companyid, equipmentcode = "F4F6F436-84AA-429A-8271-24CF4BE4FE41", datetime = "2019-04-23 12:00:00", surveytypecode = "EXH_Real",datas=new List<data>() { data1, data2, data3, data4 } };
            //http://localhost:1207/api/DataManipulate/DataUpLoad为上传地址，请联系长勘院获取
            var datainfo = WebApiHelper.Post<HttpResponseMsg>("http://localhost:1207/api/DataManipulate/DataUpLoad", JsonConvert.SerializeObject(monitordatamodel), companyid);
            Console.WriteLine(datainfo.ToString());
            Console.WriteLine("--------------------------------");

            //装备状态信息
            equipmentstatus edata = new equipmentstatus() { companyid = companyid, equipmentcode = "F4F6F436-84AA-429A-8271-24CF4BE4FE41", datetime = "2019-04-23 12:00:00", tagstate = "02" };
            var info= WebApiHelper.Post<HttpResponseMsg>("http://localhost:1207/api/DataManipulate/EquipmentStatus", JsonConvert.SerializeObject(edata), companyid);
            Console.WriteLine(info.ToString());
            Console.Read();
        }
    }
}
