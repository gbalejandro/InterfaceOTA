using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Guarantee
    {
        [XmlAttribute(AttributeName = "GuaranteeType")]
        private string guaranteeType;
        [XmlElement(ElementName = "GuaranteesAccepted")]
        private GuaranteesAccepted guaranteesAccepted;
        [XmlElement(ElementName = "Deadline")]
        private Deadline deadline;
        [XmlElement(ElementName = "GuaranteeDescription")]
        private GuaranteeDescription guaranteeDescription;
        [XmlElement(ElementName = "AmountPercent")]
        private AmountPercent amountPercent;

        public string GuaranteeType
        {
            get
            {
                return guaranteeType;
            }

            set
            {
                guaranteeType = value;
            }
        }

        public GuaranteesAccepted GuaranteesAccepted
        {
            get
            {
                return guaranteesAccepted;
            }

            set
            {
                guaranteesAccepted = value;
            }
        }

        public Deadline Deadline
        {
            get
            {
                return deadline;
            }

            set
            {
                deadline = value;
            }
        }

        public GuaranteeDescription GuaranteeDescription
        {
            get
            {
                return guaranteeDescription;
            }

            set
            {
                guaranteeDescription = value;
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