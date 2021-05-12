using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Enums
{
    class OfferType
    {
        public enum Offer
        {
            suggested = 1,
            oppose = 2
           
            
        }
        public static Array GetValues()
        {
            return Enum.GetValues(typeof(Offer));
        }
    }
}
