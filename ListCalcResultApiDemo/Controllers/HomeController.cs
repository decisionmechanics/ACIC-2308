namespace ListCalcResultApiDemo.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;

    public class HomeController : ApiController
    {
        public ListCalcResult Get([FromUri] string key, [FromUri] IEnumerable<string> values)
        {
            return new ListCalcResult { Key = key, Value = string.Join(",", values) };
        }
    }
}