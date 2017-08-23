using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class PaymentCard
    {
        [XmlAttribute(AttributeName = "CardCode")]
        private string cardCode;
        [XmlAttribute(AttributeName = "ExpireDate")]
        private string expireDate;
        [XmlElement(ElementName = "CardHolderName")]
        private string cardHolderName;
        [XmlElement(ElementName = "CardNumber")]
        private CardNumber cardNumber;
        [XmlElement(ElementName = "SeriesCode")]
        private SeriesCode seriesCode;
        [XmlElement(ElementName = "PaymentCardTypeThreeDomainSecurity")]
        private PaymentCardTypeThreeDomainSecurity paymentCardTypeThreeDomainSecurity;

        public string CardCode
        {
            get
            {
                return cardCode;
            }

            set
            {
                cardCode = value;
            }
        }

        public string ExpireDate
        {
            get
            {
                return expireDate;
            }

            set
            {
                expireDate = value;
            }
        }

        public string CardHolderName
        {
            get
            {
                return cardHolderName;
            }

            set
            {
                cardHolderName = value;
            }
        }

        public CardNumber CardNumber
        {
            get
            {
                return cardNumber;
            }

            set
            {
                cardNumber = value;
            }
        }

        public SeriesCode SeriesCode
        {
            get
            {
                return seriesCode;
            }

            set
            {
                seriesCode = value;
            }
        }

        public PaymentCardTypeThreeDomainSecurity PaymentCardTypeThreeDomainSecurity
        {
            get
            {
                return paymentCardTypeThreeDomainSecurity;
            }

            set
            {
                paymentCardTypeThreeDomainSecurity = value;
            }
        }
    }
}