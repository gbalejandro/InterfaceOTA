using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class GuestCounts
    {
        [XmlAttribute(AttributeName = "IsPerRoom")]
        private string isPerRoom;
        [XmlElement(ElementName = "GuestCount")]
        private List<GuestCount> guestCount;

        public string IsPerRoom
        {
            get
            {
                return isPerRoom;
            }

            set
            {
                isPerRoom = value;
            }
        }

        public List<GuestCount> GuestCount
        {
            get
            {
                return guestCount;
            }

            set
            {
                guestCount = value;
            }
        }
    }
}