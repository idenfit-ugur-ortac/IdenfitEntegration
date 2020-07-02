using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Idenfit.Entegration.Models.Task
{
    public class TaskCompleted
    {
        private string customer { get; set; }

        private string reporter { get; set; }

        private bool isContinuous { get; set; }

        private bool needChecked { get; set; }

        private int repeatCount { get; set; }

        private string place { get; set; }

        private string group { get; set; }

        private string lastState { get; set; }

        private string incidentAudit { get; set; }

        private string assignedEmployee { get; set; }

        private string assignedTeam { get; set; }

        private string tag { get; set; }

        private string questionForm { get; set; }

        private string serviceRecipient { get; set; }

        private string checkedEmployee { get; set; }

        private DateTime estStartDate { get; set; }

        private DateTime estFinishDate { get; set; }

        private DateTime estStartTime { get; set; }

        private DateTime estFinishTime { get; set; }

        private long estDuration { get; set; }

        private DateTime startTime { get; set; }

        private DateTime finishTime { get; set; }

        private long duration { get; set; }

        private List<string> titles { get; set; }

        private List<string> branches { get; set; }

        private List<string> fixtures { get; set; }

        private List<string> dependencies { get; set; }

        private List<string> attachments { get; set; }

        private List<string> questions { get; set; }

        private string description { get; set; }

        private string color { get; set; }

        private string failDescription { get; set; }
    }
}
