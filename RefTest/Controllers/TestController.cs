using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RefTest.Models;

namespace RefTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public Task<A> Get()
        {
            var a = new A();
            var c = new C
            {
                Parent = a
            };
            a.Children = new List<C>
            {
                c
            };

            return Task.FromResult(a);
        }
    }
}
