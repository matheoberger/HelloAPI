using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace microPOC2._4_docker.Controllers
{
    public class HelloController : ApiController
    {
        //Hello msg = new Hello ();
        public HelloGenerator helloGenerator = new HelloGenerator();
        public IHttpActionResult GetHello()
        {
            return Ok(helloGenerator.DoThisSweetSound());
        }
    }
}
