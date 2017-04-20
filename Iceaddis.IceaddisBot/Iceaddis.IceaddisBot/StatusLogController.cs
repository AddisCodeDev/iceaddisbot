using System.Collections.Generic;
using System.Web.Http;

namespace Iceaddis.IceaddisBot
{
    [RoutePrefix("Log")]
    public class StatusLogController : ApiController
    {

        [Route()]
        [HttpGet]
        public List<string> Receive()
        {
            return StatusLog.Logs;
        }
    }
}