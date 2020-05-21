using System;

namespace Idenfit.Entegration.Models.Guard
{
    public class GuardDeviceSession
    {
        public Guid DeviceId { get; set; }
        public string Employee { get; set; }
        public DateTime Date { get; set; }
        public string SessionEventType { get; set; }
    }
}


