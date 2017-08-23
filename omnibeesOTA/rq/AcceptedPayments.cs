using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class AcceptedPayments
    {
        [XmlElement(ElementName = "AcceptedPayment")]
        private List<AcceptedPayment> acceptedPayment;

        public List<AcceptedPayment> AcceptedPayment
        {
            get
            {
                return acceptedPayment;
            }

            set
            {
                acceptedPayment = value;
            }
        }
    }
}