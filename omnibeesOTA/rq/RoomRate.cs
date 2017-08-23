using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RoomRate
    {
        [XmlAttribute(AttributeName = "RatePlanCode")]
        private string ratePlanCode;
        [XmlAttribute(AttributeName = "RoomTypeCode")]
        private string roomTypeCode;
        [XmlAttribute(AttributeName = "NumberOfUnits")]
        private string numberOfUnits;
        [XmlAttribute(AttributeName = "PromotionCode")]
        private string promotionCode;
        [XmlAttribute(AttributeName = "GroupCode")]
        private string groupCode;
        [XmlElement(ElementName = "Total")]
        private Total total;
        [XmlElement(ElementName = "Rates")]
        private Rates rates;

        public string RatePlanCode
        {
            get
            {
                return ratePlanCode;
            }

            set
            {
                ratePlanCode = value;
            }
        }

        public string RoomTypeCode
        {
            get
            {
                return roomTypeCode;
            }

            set
            {
                roomTypeCode = value;
            }
        }

        public string NumberOfUnits
        {
            get
            {
                return numberOfUnits;
            }

            set
            {
                numberOfUnits = value;
            }
        }

        public string PromotionCode
        {
            get
            {
                return promotionCode;
            }

            set
            {
                promotionCode = value;
            }
        }

        public string GroupCode
        {
            get
            {
                return groupCode;
            }

            set
            {
                groupCode = value;
            }
        }

        public Total Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public Rates Rates
        {
            get
            {
                return rates;
            }

            set
            {
                rates = value;
            }
        }
    }
}