using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Rate
    {
        [XmlAttribute(AttributeName = "EffectiveDate")]
        private string effectiveDate;
        [XmlElement(ElementName = "Total")]
        private Total total;

        public string EffectiveDate
        {
            get
            {
                return effectiveDate;
            }

            set
            {
                effectiveDate = value;
            }
        }

        public Total Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}