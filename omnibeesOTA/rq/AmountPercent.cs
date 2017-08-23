using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class AmountPercent
    {
        [XmlAttribute(AttributeName = "Amount")]
        private string amount;
        [XmlAttribute(AttributeName = "Percent")]
        private string percent;
        [XmlAttribute(AttributeName = "NmbrOfNights")]
        private string nmbrOfNights;
        [XmlElement(ElementName = "Taxes")]
        private Taxes taxes;

        public string Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string Percent
        {
            get
            {
                return percent;
            }

            set
            {
                percent = value;
            }
        }

        public string NmbrOfNights
        {
            get
            {
                return nmbrOfNights;
            }

            set
            {
                nmbrOfNights = value;
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