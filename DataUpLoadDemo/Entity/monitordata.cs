using APDataUpLoadDemoI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataUpLoadDemo.Entity
{
    public class monitordata
    {
        public string companyid { set; get; }
        public string equipmentcode { set; get; }
        public string datetime { set; get; }
        public string surveytypecode { set; get; }
        public List<data> datas { set; get; }
    }
}