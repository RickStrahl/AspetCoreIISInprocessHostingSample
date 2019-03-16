using System;
using System.Reflection;
using System.Runtime.Versioning;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace PerfTest.Controllers
{
    public class TestController : Controller
    {
        [Route("api/helloworld")]
        public string HelloWorld()
        {
            return "Hello World. Time is: " + DateTime.Now.ToString();
        }

        [Route("api/helloworldjson")]
        public object HelloWorldJson()
        {
            return new
            {
                Message = "Hello World. Time is: " + DateTime.Now.ToString(),
                Time = DateTime.Now
            };
        }

        [Route("api/staticpage")]
        public string StaticPage()
        {
            return "STATIC PAGE OUTPUT REDIRECT FROM IIS";
        }

        [HttpPost]       
        [Route("api/helloworldjson")]
        public object HelloWorldJsonPost([FromForm] string name)
        {
            return new
            {
                Message = $"Hello {name}. Time is: " + DateTime.Now.ToString(),
                Time = DateTime.Now
            };
        }

        [HttpPost]        
        [Route("api/helloworldpost")]
        public object HelloWorldPost(string name)
        {
            return $"Hello {name}. Time is: " + DateTime.Now.ToString();
        }
//        
//        [HttpGet("api/applicationstats")]
//        public object GetApplicationStats()
//        {
//            // Seriously?
//            //var desc = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
//
//            var rt = typeof(string)
//                .GetTypeInfo()
//                .Assembly
//                .GetCustomAttribute<AssemblyFileVersionAttribute>();
//            var v = new Version(rt.Version);
//
//            var entryAss = Assembly.GetEntryAssembly();
//            var vname = Assembly.GetEntryAssembly()?.GetCustomAttribute<TargetFrameworkAttribute>()?.FrameworkName;
//
//            
//            var stats = new
//            {
//                OsPlatform = System.Runtime.InteropServices.RuntimeInformation.OSDescription,                
//                DotnetCoreVersion = vname,            
//            };
//
//            
//            return stats;
//        }

    }

    public class Item
    {
        public string Name { get; set; }
    }
}
