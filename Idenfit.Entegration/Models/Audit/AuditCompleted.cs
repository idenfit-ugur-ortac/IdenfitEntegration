using System;
using System.Collections.Generic;

namespace Idenfit.Entegration.Models.Audit
{
    public class AuditCompleted
    {
        public Model customer { get; set; }

        public string reportLink { get; set; }

        public Model reporter { get; set; }

        public bool isContinuous { get; set; }

        public bool needChecked { get; set; }

        public int repeatCount { get; set; }

        public Model place { get; set; }

        public Model group { get; set; }

        public string lastState { get; set; }

        public Model incidentAudit { get; set; }

        public Model assignedEmployee { get; set; }

        public Model assignedTeam { get; set; }

        public Model tag { get; set; }

        public Model questionForm { get; set; }

        public Model serviceRecipient { get; set; }

        public Model checkedEmployee { get; set; }

        public DateTime? estStartDate { get; set; }

        public DateTime? estFinishDate { get; set; }

        public DateTime? estStartTime { get; set; }

        public DateTime? estFinishTime { get; set; }

        public long? estDuration { get; set; }

        public DateTime? startTime { get; set; }

        public DateTime? finishTime { get; set; }

        public long? duration { get; set; }

        public List<Model> titles { get; set; }

        public List<Model> branches { get; set; }

        public List<Model> fixtures { get; set; }

        public List<Model> dependencies { get; set; }

        public List<Model> attachments { get; set; }

        public List<Model> personnel { get; set; }

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
