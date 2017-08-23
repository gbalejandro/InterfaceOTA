using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Rates
    {
        [XmlElement(ElementName = "Rate")]
        private List<Rate> rate;

        public List<Rate> Rate
        {
            get
            {
                return rate;
            }

            set
            {
                rate = value;
            }
        }
    }
}