using Com.Ctrip.Framework.Apollo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webapi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IConfiguration _configration;

        public HomeController(IConfiguration configration)
        {
            _configration = configration ;
        }
        [EnableCors("b")]
        public string Index()
        {
            string value = _configration.GetValue<string>("timeout");
            return "hello Linux";
        }

    }
}
