using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class HotelReservation
    {
        [XmlAttribute(AttributeName = "ResStatus")]
        private string resStatus;
        [XmlAttribute(AttributeName = "CreateDateTime")]
        private string createDateTime;
        [XmlAttribute(AttributeName = "LastModifyDateTime")]
        private string lastModifyDateTime;
        [XmlElement(ElementName = "POS")]
        private POS pOS;
        [XmlElement(ElementName = "UniqueID", Namespace = "omnibeesOTA.rq")]
        private rq.UniqueID uniqueID;
        [XmlElement(ElementName = "RoomStays")]
        private RoomStays roomStays;
        [XmlElement(ElementName = "Services")]
        private Services services;
        [XmlElement(ElementName = "ResGuests")]
        private ResGuests resGuests;
        [XmlElement(ElementName = "ResGlobalInfo")]
        private ResGlobalInfo resGlobalInfo;

        public string ResStatus
        {
            get
            {
                return resStatus;
            }

            set
            {
                resStatus = value;
            }
        }

        public string CreateDateTime
        {
            get
            {
                return createDateTime;
            }

            set
            {
                createDateTime = value;
            }
        }

        public string LastModifyDateTime
        {
            get
            {
                return lastModifyDateTime;
            }

            set
            {
                lastModifyDateTime = value;
            }
        }

        public POS POS
        {
            get
            {
                return pOS;
            }

            set
            {
                pOS = value;
            }
        }

        public UniqueID UniqueID
        {
            get
            {
                return uniqueID;
            }

            set
            {
                uniqueID = value;
            }
        }

        public RoomStays RoomStays
        {
            get
            {
                return roomStays;
            }

            set
            {
                roomStays = value;
            }
        }

        public Services Services
        {
            get
            {
                return services;
            }

            set
            {
                services = value;
            }
        }

        public ResGuests ResGuests
        {
            get
            {
                return resGuests;
            }

            set
            {
                resGuests = value;
            }
        }

        public ResGlobalInfo ResGlobalInfo
        {
            get
            {
                return resGlobalInfo;
            }

            set
            {
                resGlobalInfo = value;
            }
        }
    }
}