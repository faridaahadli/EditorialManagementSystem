using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Enums
{
    public class Degree
    {
        public enum Degrees
        {
           MSc=1,
           Phd=2,
           BSc=3
        }
        public static Array GetValues()
        {
            return Enum.GetValues(typeof(Degrees));
        }
    }
}
