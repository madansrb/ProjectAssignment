using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebAPI_Assignment.Models;

namespace WebAPI_Assignment.Controllers
{
    public class StreamController : ApiController
    {
        private readonly IStream _workerService;
        
         

        public StreamController():this(new Algorithem())
     {
        }
        public StreamController(IStream service)
        {
            _workerService = service;
            
        }

        [HttpGet]
        [Route("StreamProcessing/Garbage")]
        public async Task<HttpResponseMessage> Garbage(string Inputstream)
        {
            int GroupCount= _workerService.GarbageIdentify(Inputstream); 
            string result = Inputstream + ": score is  " + GroupCount;
            return Request.CreateResponse(HttpStatusCode.OK, new { result });
        }


    }
}
