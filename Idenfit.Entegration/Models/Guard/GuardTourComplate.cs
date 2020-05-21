using System;

namespace Idenfit.Entegration.Models.Guard
{
    public class GuardTourComplate
    {
        public Guid DeviceId { get; set; }
        public Guid BranchId { get; set; }
        public Guid? RecordId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan TotalTime { get; set; }

        public string TaskName { get; set; }
        public string Employee { get; set; }

        public long? Tag { get; set; }
    }
}
