using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class ResGlobalInfo
    {
        [XmlElement(ElementName = "BasicPropertyInfo")]
        private BasicPropertyInfo basicPropertyInfo;
        [XmlElement(ElementName = "HotelReservationIDs")]
        private List<HotelReservationID> hotelReservationIDs;
        [XmlElement(ElementName = "GuestCounts")]
        private GuestCounts guestCounts;
        [XmlElement(ElementName = "Comments")]
        private Comments comments;
        [XmlElement(ElementName = "Total")]
        private Total total;
        [XmlElement(ElementName = "Profiles")]
        private Profiles profiles;
        [XmlElement(ElementName = "DepositPayments")]
        private DepositPayments depositPayments;
        [XmlElement(ElementName = "Guarantee")]
        private Guarantee guarantee;

        public BasicPropertyInfo BasicPropertyInfo
        {
            get
            {
                return basicPropertyInfo;
            }

            set
            {
                basicPropertyInfo = value;
            }
        }

        public List<HotelReservationID> HotelReservationIDs
        {
            get
            {
                return hotelReservationIDs;
            }

            set
            {
                hotelReservationIDs = value;
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

        public Comments Comments
        {
            get
            {
                return comments;
            }

            set
            {
                comments = value;
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

        public Profiles Profiles
        {
            get
            {
                return profiles;
            }

            set
            {
                profiles = value;
            }
        }

        public DepositPayments DepositPayments
        {
            get
            {
                return depositPayments;
            }

            set
            {
                depositPayments = value;
            }
        }

        public Guarantee Guarantee
        {
            get
            {
                return guarantee;
            }

            set
            {
                guarantee = value;
            }
        }
    }
}