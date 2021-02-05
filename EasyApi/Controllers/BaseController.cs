using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyApi.Controllers
{
    public class BaseController: ControllerBase
    {
        public static NLog.ILogger logger;
        static BaseController()
        {
            logger = NLog.LogManager.GetCurrentClassLogger();
        }
    }
}
