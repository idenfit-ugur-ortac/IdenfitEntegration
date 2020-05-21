using Idenfit.Entegration.Models;
using Idenfit.Entegration.Models.Guard;
using Microsoft.AspNetCore.Mvc;

namespace Idenfit.Entegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuardSignalController : Controller
    {
        [HttpPost("GuardTourStart")]
        public ClientResult Post([FromBody] GuardTourStart signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourStart"
            };
        }
        [HttpPost("GuardTourFnish")]
        public ClientResult Post([FromBody] GuardTourFnish signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourFnish"
            };
        }
        [HttpPost("GuardTourRead")]
        public ClientResult Post([FromBody] GuardTourRead signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourRead"
            };
        }
        [HttpPost("GuardTourReminder")]
        public ClientResult Post([FromBody] GuardTourReminder signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourReminder"
            };
        }
        [HttpPost("GuardTourNotRead")]
        public ClientResult Post([FromBody] GuardTourNotRead signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourNotRead"
            };
        }
        [HttpPost("GuardTourSkipped")]
        public ClientResult Post([FromBody] GuardTourSkipped signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourSkipped"
            };
        }
        [HttpPost("GuardTourTimeViolation")]
        public ClientResult Post([FromBody] GuardTourTimeViolation signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourTimeViolation"
            };
        }
        [HttpPost("GuardTourStationTimeViolation")]
        public ClientResult Post([FromBody] GuardTourStationTimeViolation signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourStationTimeViolation"
            };
        }
        [HttpPost("GuardTourComplate")]
        public ClientResult Post([FromBody] GuardTourComplate signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourComplate"
            };
        }
        [HttpPost("GuardTourInComplate")]
        public ClientResult Post([FromBody] GuardTourInComplate signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourInComplate"
            };
        }
        [HttpPost("GuardTourNotVisited")]
        public ClientResult Post([FromBody] GuardTourNotVisited signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardTourNotVisited"
            };
        }
        [HttpPost("GuardDeviceSession")]
        public ClientResult Post([FromBody] GuardDeviceSession signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardDeviceSession"
            };
        }
        [HttpPost("GuardDeviceOff")]
        public ClientResult Post([FromBody] GuardDeviceOff signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardDeviceOff"
            };
        }
        [HttpPost("GuardDeviceStatus")]
        public ClientResult Post([FromBody] GuardDeviceStatus signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardDeviceStatus"
            };
        }
        [HttpPost("GuardEmergencyCall")]
        public ClientResult Post([FromBody] GuardEmergencyCall signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardEmergencyCall"
            };
        }
        [HttpPost("GuardEmergencySms")]
        public ClientResult Post([FromBody] GuardEmergencySms signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardEmergencySms"
            };
        }
        [HttpPost("GuardEvent")]
        public ClientResult Post([FromBody] GuardEvent signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardEvent"
            };
        }
        [HttpPost("GuardJudicialEvent")]
        public ClientResult Post([FromBody] GuardJudicialEvent signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardJudicialEvent"
            };
        }
        [HttpPost("GuardMandown")]
        public ClientResult Post([FromBody] GuardMandown signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardMandown"
            };
        }
        [HttpPost("GuardOutsideLocation")]
        public ClientResult Post([FromBody] GuardOutsideLocation signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardOutsideLocation"
            };
        }
        [HttpPost("GuardSos")]
        public ClientResult Post([FromBody] GuardSos signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardSos"
            };
        }
   
        [HttpPost("GuardDeviceBatteryAlarm")]
        public ClientResult Post([FromBody] GuardDeviceBatteryAlarm signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardDeviceBatteryAlarm"
            };
        }
        [HttpPost("GuardAppReport")]
        public ClientResult Post([FromBody] GuardAppReport signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardAppReport"
            };
        }
        [HttpPost("GuardRestartReport")]
        public ClientResult Post([FromBody] GuardRestartReport signal)
        {
            return new ClientResult
            {
                State = true,

                Message = $"Signal GuardRestartReport"
            };
        }
    }
}
