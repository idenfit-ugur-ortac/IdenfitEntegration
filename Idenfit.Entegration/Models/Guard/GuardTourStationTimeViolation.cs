using System;

namespace Idenfit.Entegration.Models.Guard
{
    public class GuardTourStationTimeViolation
    {
        public Guid DeviceId { get; set; }
        public Guid RecordId { get; set; }
        public Guid BranchId { get; set; }
        public DateTime Date { get; set; }
        public string TaskName { get; set; }
        public string TaskTypeName { get; set; }
        public string TaskPlan { get; set; }
        public string EmployeeName { get; set; }
        public string StationName { get; set; }
        public long MinStationTime { get; set; }
        public long MaxStationTime { get; set; }
        public TimeSpan TotalTime { get; set; }

        public long? Tag { get; set; }
    }
}
