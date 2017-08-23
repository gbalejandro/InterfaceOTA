using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class GuaranteeAccepted
    {
        [XmlAttribute(AttributeName = "GuaranteeTypeCode")]
        private string guaranteeTypeCode;
        [XmlAttribute(AttributeName = "GuaranteeID")]
        private string guaranteeID;
        [XmlElement(ElementName = "PaymentCard")]
        private PaymentCard paymentCard;

        public string GuaranteeTypeCode
        {
            get
            {
                return guaranteeTypeCode;
            }

            set
            {
                guaranteeTypeCode = value;
            }
        }

        public string GuaranteeID
        {
            get
            {
                return guaranteeID;
            }

            set
            {
                guaranteeID = value;
            }
        }

        public PaymentCard PaymentCard
        {
            get
            {
                return paymentCard;
            }

            set
            {
                paymentCard = value;
            }
        }
    }
}