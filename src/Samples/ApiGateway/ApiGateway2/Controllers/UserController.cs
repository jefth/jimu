﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jimu.Client;
using Microsoft.AspNetCore.Mvc;
using Simple.IServices;

namespace ApiGateway2.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private IServiceProxy _serviceProxy;
        public ValuesController(IServiceProxy serviceProxy)
        {
            this._serviceProxy = serviceProxy;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var userService = _serviceProxy.GetService<IUserService>();
            var userid = userService.GetId();
            return new string[] { "value1", "value2", userid };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}