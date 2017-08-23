using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Total
    {
        [XmlAttribute(AttributeName = "AmountBeforeTax")]
        private double amountBeforeTax;
        [XmlAttribute(AttributeName = "AmountAfterTax")]
        private double amountAfterTax;
        [XmlAttribute(AttributeName = "CurrencyCode")]
        private string currencyCode;
        [XmlElement(ElementName = "Taxes")]
        private Taxes taxes;

        public double AmountBeforeTax
        {
            get
            {
                return amountBeforeTax;
            }

            set
            {
                amountBeforeTax = value;
            }
        }

        public double AmountAfterTax
        {
            get
            {
                return amountAfterTax;
            }

            set
            {
                amountAfterTax = value;
            }
        }

        public string CurrencyCode
        {
            get
            {
                return currencyCode;
            }

            set
            {
                currencyCode = value;
            }
        }

        public Taxes Taxes
        {
            get
            {
                return taxes;
            }

            set
            {
                taxes = value;
            }
        }
    }
}