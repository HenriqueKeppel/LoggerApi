using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoggerApi.Domain.Models;
using LoggerApi.Domain.PostObjects;

namespace LoggerApi.Controllers
{
    [Route("LoggerApi/v1/[controller]")]
    public class LoggerController : Controller
    {
        // POST api/values
        [HttpPost]
        public async Task<LoggerPost> Post([FromBody]LoggerModel model)
        {
            LoggerPost result = new LoggerPost(200);
            return result;
        }

        [HttpPost("PagamentoLogger")]
        public async Task<LoggerPost> Post([FromBody]LoggerPagamentoModel request)
        {
            LoggerPost result = new LoggerPost(200);
            return result;
        }
    }
}
