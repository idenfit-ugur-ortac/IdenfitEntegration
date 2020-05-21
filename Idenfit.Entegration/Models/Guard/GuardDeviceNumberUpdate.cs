using System;

namespace Idenfit.Entegration.Models.Guard
{
    public class GuardDeviceNumberUpdate
    {
        public Guid DeviceId { get; set; }

        public long PhoneNumber { get; set; }
    }
}
