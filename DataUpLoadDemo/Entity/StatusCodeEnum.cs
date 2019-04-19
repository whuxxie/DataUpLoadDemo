using DataUpLoadDemo.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataUpLoadDemo.Entity
{
    public enum StatusCodeEnum
    {
        [Text("请求(或处理)成功")]
        Success = 200, //请求(或处理)成功

        [Text("内部请求出错")]
        Error = 500, //内部请求出错

        [Text("未授权标识")]
        Unauthorized = 401,//未授权标识

        [Text("请求参数不完整或不正确")]
        ParameterError = 400,//请求参数不完整或不正确

        [Text("请求TOKEN失效")]
        TokenInvalid = 403,//请求TOKEN失效

        [Text("HTTP请求类型不合法")]
        HttpMehtodError = 405,//HTTP请求类型不合法

        [Text("HTTP请求不合法,请求参数可能被篡改")]
        HttpRequestError = 406,//HTTP请求不合法

        [Text("该URL已经失效")]
        URLExpireError = 407,//HTTP请求不合法

        [Text("存在空字段")]
        FieldEmpty = 408,//存在空字段

        [Text("赋值错误")]
        ValueError = 409,//赋值错误

        [Text("监测点配置错误")]
        PointConfigError = 410,//监测点配置错误

        [Text("surveytypecode错误")]
        SurveytypeCodeError = 411,//surveytypecode错误

        [Text("不存在该公司")]
        CompanyNull = 412,//不存在该公司

        [Text("数据入库失败")]
        DBInsertError = 413,//数据入库失败
    }
}
