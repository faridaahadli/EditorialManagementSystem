using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Enums
{
    class Status
    {
        public enum Statuses
        {
            pending = 1,
            accepted = 2,
            rejected=3
        }
        public static Array GetValues()
        {
            return Enum.GetValues(typeof(Statuses));
        }
    }
}
