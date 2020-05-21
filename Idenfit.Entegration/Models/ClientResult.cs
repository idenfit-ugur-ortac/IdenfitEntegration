using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Idenfit.Entegration.Models
{
    public class ClientResult
    {
        public bool State { get; set; }
        public string Message { get; set; }
        public long? Tag { get; set; }
    }
}
