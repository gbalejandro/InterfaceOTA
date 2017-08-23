using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class CancelPenalties
    {
        [XmlElement(ElementName = "CancelPenalty")]
        private List<CancelPenalty> cancelPenalty;

        public List<CancelPenalty> CancelPenalty
        {
            get
            {
                return cancelPenalty;
            }

            set
            {
                cancelPenalty = value;
            }
        }
    }
}