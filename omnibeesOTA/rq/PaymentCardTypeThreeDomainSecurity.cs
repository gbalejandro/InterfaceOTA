using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class PaymentCardTypeThreeDomainSecurity
    {
        [XmlElement(ElementName = "Results")]
        private Results results;

        public Results Results
        {
            get
            {
                return results;
            }

            set
            {
                results = value;
            }
        }
    }
}