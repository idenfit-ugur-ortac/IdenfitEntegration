using System;
using System.Collections.Generic;

namespace Idenfit.Entegration.Models.Guard
{
    public class GuardTourInComplate
    {
        public Guid DeviceId { get; set; }
        public Guid BranchId { get; set; }
        public Guid? RecordId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan TotalTime { get; set; }
        public List<string> MissingStations { get; set; }

        public string TaskName { get; set; }
        public string Employee { get; set; }

        public long? Tag { get; set; }

        public GuardTourInComplate()
        {
            MissingStations = new List<string>();
        }
    }
}
