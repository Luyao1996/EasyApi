using Easy.IBLL;
using Easy.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : BaseController
    {
        private readonly ITestBll TestBll;
        public TestController(ITestBll testBll)
        {
            TestBll = testBll;
        }

        [HttpPost]
        public async ValueTask<string> Get(MTest test)
        {
            return await TestBll.Get();
            //throw new Exception("test exception");
           // return "OK";
        }
    }
}
