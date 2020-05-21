using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Idenfit.Entegration.Models.Task
{
    public class TaskIncident
    {
        private string employee { get; set; }

        private string incidentTask { get; set; }

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
