using Idenfit.Entegration.Models;
using Idenfit.Entegration.Models.Audit;
using Microsoft.AspNetCore.Mvc;

namespace Idenfit.Entegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuditSignalController : Controller
    {
        [HttpPost("AuditCreated")]
        public ClientResult Post([FromBody] AuditCreated signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal AuditCreated"
            };
        }

        [HttpPost("AuditStateChanged")]
        public ClientResult Post([FromBody] AuditStateChanged signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal AuditStateChanged"
            };
        }

        [HttpPost("AuditCompleted")]
        public ClientResult Post([FromBody] AuditCompleted signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal AuditCompleted"
            };
        }

        [HttpPost("AuditFail")]
        public ClientResult Post([FromBody] AuditFail signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal AuditFail"
            };
        }

        [HttpPost("AuditIncident")]
        public ClientResult Post([FromBody] AuditIncident signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal AuditIncident"
            };
        }
    }
}
