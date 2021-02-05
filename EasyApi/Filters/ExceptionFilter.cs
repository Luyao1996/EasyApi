using Easy.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Easy.Util.Judge;
using Easy.Util;
using Microsoft.AspNetCore.Mvc;

namespace EasyApi.Filters
{
    /// <summary>
    /// 全局异常捕获
    /// </summary>
    public class ExceptionFilter : IExceptionFilter
    {
        /// <summary>
        /// 异常时执行的代码
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            var res = new Result();
            res.Code = StatusCodes.Status500InternalServerError;
            res.Msg = "服务器错误";
            if (context != null && context.Exception != null && !context.Exception.Message.IsEmpty())
            {
                res.Msg += "：" + context.Exception.Message;
            }
            string errRet = res.ToJson();
            if (context.ExceptionHandled == false)
            {
                context.Result = new ContentResult
                {
                    Content = errRet,
                    StatusCode = StatusCodes.Status200OK,
                    ContentType = "application/json"
                };
            }
            context.ExceptionHandled = true;

            NLog.LogManager.GetCurrentClassLogger().Error(context.Exception.ToString());
        }
        /// <summary>
        /// 异步异常时执行的代码
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public Task OnExceptionAsync(ExceptionContext context)
        {
            OnException(context);
            return Task.CompletedTask;
        }
    }
}
