using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUpLoadDemo.Entity
{
    public class HttpResponseMsg
    {
        public int StatusCode { get; set; }
        public object Data { get; set; }
        public string Info { get; set; }

        public override string ToString()
        {
            return StatusCode.ToString()+"\t"+Info+"\t"+Data.ToString();
        }
    }

    public class MonitordataResultMsg:HttpResponseMsg
    {
        public monitordata Result
        {
            get
            {
                if (StatusCode == (int)StatusCodeEnum.Success)
                {
                    return JsonConvert.DeserializeObject<monitordata>(Data.ToString());
                }

                return null;
            }
        }
    }

    public class TokenResultMsg : HttpResponseMsg
    {
        public Token Result
        {
            get
            {
                if (StatusCode == (int)StatusCodeEnum.Success)
                {
                    return JsonConvert.DeserializeObject<Token>(Data.ToString());
                }

                return null;
            }
        }
        public override string ToString()
        {
            return StatusCode.ToString() + "\t" + Info + "\t" + Data.ToString();
        }
    }
}
