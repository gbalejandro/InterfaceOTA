using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RatePlans
    {
        [XmlElement(ElementName = "RatePlan")]
        private List<RatePlan> ratePlan;

        public List<RatePlan> RatePlan
        {
            get
            {
                return ratePlan;
            }

            set
            {
                ratePlan = value;
            }
        }
    }
}