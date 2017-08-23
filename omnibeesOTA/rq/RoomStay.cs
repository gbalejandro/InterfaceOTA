using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RoomStay
    {
        [XmlAttribute(AttributeName = "IndexNumber")]
        private string indexNumber;
        [XmlAttribute(AttributeName = "PromotionCode")]
        private string promotionCode;
        [XmlElement(ElementName = "RoomTypes")]
        private RoomTypes roomTypes;
        [XmlElement(ElementName = "RatePlans")]
        private RatePlans ratePlans;
        [XmlElement(ElementName = "RoomRates")]
        private RoomRates roomRates;
        [XmlElement(ElementName = "GuestCounts")]
        private GuestCounts guestCounts;
        [XmlElement(ElementName = "TimeSpan")]
        private TimeSpan timeSpan;
        [XmlElement(ElementName = "CancelPenalties")]
        private CancelPenalties cancelPenalties;
        [XmlElement(ElementName = "Total")]
        private Total total;
        [XmlElement(ElementName = "ResGuestRPHs")]
        private string resGuestRPHs;
        [XmlElement(ElementName = "ServiceRPHs")]
        private ServiceRPHs serviceRPHs;

        public string IndexNumber
        {
            get
            {
                return indexNumber;
            }

            set
            {
                indexNumber = value;
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

        public RoomTypes RoomTypes
        {
            get
            {
                return roomTypes;
            }

            set
            {
                roomTypes = value;
            }
        }

        public RatePlans RatePlans
        {
            get
            {
                return ratePlans;
            }

            set
            {
                ratePlans = value;
            }
        }

        public RoomRates RoomRates
        {
            get
            {
                return roomRates;
            }

            set
            {
                roomRates = value;
            }
        }

        public GuestCounts GuestCounts
        {
            get
            {
                return guestCounts;
            }

            set
            {
                guestCounts = value;
            }
        }

        public TimeSpan TimeSpan
        {
            get
            {
                return timeSpan;
            }

            set
            {
                timeSpan = value;
            }
        }

        public CancelPenalties CancelPenalties
        {
            get
            {
                return cancelPenalties;
            }

            set
            {
                cancelPenalties = value;
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

        public string ResGuestRPHs
        {
            get
            {
                return resGuestRPHs;
            }

            set
            {
                resGuestRPHs = value;
            }
        }

        public ServiceRPHs ServiceRPHs
        {
            get
            {
                return serviceRPHs;
            }

            set
            {
                serviceRPHs = value;
            }
        }
    }
}