using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyApi.MiddleWare
{
    public class MiddleRequestHandle
    {
        public Action<HttpContext, Func<Task>> action;

        //public MiddleRequestHandle(HttpContext context, Func<Task> next)
        //{
        //    action += RequestTime(context, next);
        //}

        //public Action<HttpContext, Func<Task>> RequestTime(HttpContext context, Func<Task> next)
        //{
        //    var a = 1;
        //    await next();
        //    var b = 2;
        //}
    }
}
