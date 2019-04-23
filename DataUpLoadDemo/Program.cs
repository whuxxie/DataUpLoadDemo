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
            string companyid = (AppSettingsConfig.CompanyId);
            var tokenResult = WebApiHelper.GetSignToken(companyid);
            Console.WriteLine(tokenResult.ToString());

            data data1 = new data() { tagid = "S01-Rtd", tagname = "XXX", tagdata = "12.21", tagstate = "00" };
            data data2 = new data() { tagid = "S02-Rtd", tagname = "XXX", tagdata = "13.21", tagstate = "00" };
            data data3 = new data() { tagid = "S03-Rtd", tagname = "XXX", tagdata = "112.21", tagstate = "00" };
            data data4 = new data() { tagid = "S04-Rtd", tagname = "XXX", tagdata = "133.21", tagstate = "00" };
            monitordata monitordatamodel = new monitordata() { companyid = companyid, equipmentcode = "F4F6F436-84AA-429A-8271-24CF4BE4FE41", datetime = "2019-04-23 12:00:00", surveytypecode = "EXH_Real",datas=new List<data>() { data1, data2, data3, data4 } };
            var datainfo = WebApiHelper.Post<HttpResponseMsg>("http://localhost:1207/api/DataManipulate/DataUpLoad", JsonConvert.SerializeObject(monitordatamodel), companyid);
            Console.WriteLine(datainfo.ToString());
            Console.WriteLine("--------------------------------");

            equipmentstatus edata = new equipmentstatus() { companyid = companyid, equipmentcode = "F4F6F436-84AA-429A-8271-24CF4BE4FE41", datetime = "2019-04-23 12:00:00", tagstate = "02" };
            var info= WebApiHelper.Post<HttpResponseMsg>("http://localhost:1207/api/DataManipulate/EquipmentStatus", JsonConvert.SerializeObject(edata), companyid);
            Console.WriteLine(info.ToString());
            Console.Read();
        }
    }
}
