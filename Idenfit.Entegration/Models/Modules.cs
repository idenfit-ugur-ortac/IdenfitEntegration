using System;

namespace Idenfit.Entegration.Models
{
    public class Modules
    {
        [Flags]
        public enum Module
        {
            Guard = 1,
            Task = 2,
            Audit = 4,
        }
    }
}
