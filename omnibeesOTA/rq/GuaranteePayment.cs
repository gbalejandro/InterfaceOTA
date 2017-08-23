using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class GuaranteePayment
    {
        [XmlAttribute(AttributeName = "PaymentCode")]
        private string paymentCode;
        [XmlElement(ElementName = "AcceptedPayments")]
        private AcceptedPayments acceptedPayments;
        [XmlElement(ElementName = "AmountPercent")]
        private AmountPercent amountPercent;

        public string PaymentCode
        {
            get
            {
                return paymentCode;
            }

            set
            {
                paymentCode = value;
            }
        }

        public AcceptedPayments AcceptedPayments
        {
            get
            {
                return acceptedPayments;
            }

            set
            {
                acceptedPayments = value;
            }
        }

        public AmountPercent AmountPercent
        {
            get
            {
                return amountPercent;
            }

            set
            {
                amountPercent = value;
            }
        }
    }
}