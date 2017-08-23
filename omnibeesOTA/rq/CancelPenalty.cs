using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class CancelPenalty
    {
        [XmlAttribute(AttributeName = "NonRefundable")]
        private string nonRefundable;
        [XmlElement(ElementName = "Deadline")]
        private Deadline deadline;
        [XmlElement(ElementName = "AmountPercent")]
        private AmountPercent amountPercent;
        [XmlElement(ElementName = "PenaltyDescription")]
        private PenaltyDescription penaltyDescription;

        public string NonRefundable
        {
            get
            {
                return nonRefundable;
            }

            set
            {
                nonRefundable = value;
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

        public PenaltyDescription PenaltyDescription
        {
            get
            {
                return penaltyDescription;
            }

            set
            {
                penaltyDescription = value;
            }
        }
    }
}