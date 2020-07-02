using System;
using System.Collections.Generic;

namespace Idenfit.Entegration.Models.Audit
{
    public class AuditQuestion
    {
        public string groupName { get; set; }

        public string name { get; set; }

        public int? point { get; set; }

        public string answer { get; set; }

        public string type { get; set; }

        public bool? valid { get; set; }

        public List<string> comments { get; set; }

        public List<string> photos { get; set; }

        public List<string> documents { get; set; }

        public List<string> videos { get; set; }
    }
}
