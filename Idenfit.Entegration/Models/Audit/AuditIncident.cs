using System;
using System.Collections.Generic;

namespace Idenfit.Entegration.Models.Audit
{
    public class AuditIncident
    {
        private string employee { get; set; }

        private string incidentAudit { get; set; }

        private string branch { get; set; }

        private string explanation { get; set; }

        private bool isJudicial { get; set; }

        private bool isQuick { get; set; }

        private float latitude { get; set; }

        private float longitude { get; set; }

        private DateTime incidentTime { get; set; }

        private List<string> details { get; set; }
    }
}
