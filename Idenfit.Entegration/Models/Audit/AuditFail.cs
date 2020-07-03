using System;
using System.Collections.Generic;

namespace Idenfit.Entegration.Models.Audit
{
    public class AuditFail
    {
        public string customer { get; set; }

        public string reporter { get; set; }

        public bool isContinuous { get; set; }

        public bool needChecked { get; set; }

        public int repeatCount { get; set; }

        public string place { get; set; }

        public string group { get; set; }

        public string lastState { get; set; }

        public string incidentAudit { get; set; }

        public string assignedEmployee { get; set; }

        public string assignedTeam { get; set; }

        public string tag { get; set; }

        public string questionForm { get; set; }

        public string serviceRecipient { get; set; }

        public string checkedEmployee { get; set; }

        public DateTime? estStartDate { get; set; }

        public DateTime? estFinishDate { get; set; }

        public DateTime? estStartTime { get; set; }

        public DateTime? estFinishTime { get; set; }

        public long? estDuration { get; set; }

        public DateTime? startTime { get; set; }

        public DateTime? finishTime { get; set; }

        public long? duration { get; set; }

        public List<string> titles { get; set; }

        public List<string> branches { get; set; }

        public List<string> fixtures { get; set; }

        public List<string> dependencies { get; set; }

        public List<string> attachments { get; set; }

        public List<string> personnel { get; set; }

        public List<AuditQuestion> questions { get; set; }

        public string description { get; set; }

        public string color { get; set; }

        public string failDescription { get; set; }

        public int? scoreType { get; set; }

        public float? score { get; set; }

        public string scoreDescription { get; set; }

        public string signatureCustomer { get; set; }

        public string type { get; set; }

        public string priority { get; set; }
    }
}
