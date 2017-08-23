using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class ResGuest
    {
        [XmlAttribute(AttributeName = "ResGuestRPH")]
        private string resGuestRPH;
        [XmlAttribute(AttributeName = "PrimaryIndicator")]
        private string primaryIndicator;
        [XmlAttribute(AttributeName = "ArrivalTime")]
        private string arrivalTime;
        [XmlElement(ElementName = "Profiles")]
        private Profiles profiles;

        public string ResGuestRPH
        {
            get
            {
                return resGuestRPH;
            }

            set
            {
                resGuestRPH = value;
            }
        }

        public string PrimaryIndicator
        {
            get
            {
                return primaryIndicator;
            }

            set
            {
                primaryIndicator = value;
            }
        }

        public string ArrivalTime
        {
            get
            {
                return arrivalTime;
            }

            set
            {
                arrivalTime = value;
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
    }
}