using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class DepositPayments
    {
        [XmlElement(ElementName = "GuaranteePayment")]
        private List<GuaranteePayment> guaranteePayment;

        public List<GuaranteePayment> GuaranteePayment
        {
            get
            {
                return guaranteePayment;
            }

            set
            {
                guaranteePayment = value;
            }
        }
    }
}