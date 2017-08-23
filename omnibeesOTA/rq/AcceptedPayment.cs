using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class AcceptedPayment
    {
        [XmlAttribute(AttributeName = "RPH")]
        private string rPH;
        [XmlAttribute(AttributeName = "PaymentTransactionTypeCode")]
        private string paymentTransactionTypeCode;
        [XmlElement(ElementName = "PaymentCard")]
        private PaymentCard paymentCard;

        public string RPH
        {
            get
            {
                return rPH;
            }

            set
            {
                rPH = value;
            }
        }

        public string PaymentTransactionTypeCode
        {
            get
            {
                return paymentTransactionTypeCode;
            }

            set
            {
                paymentTransactionTypeCode = value;
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