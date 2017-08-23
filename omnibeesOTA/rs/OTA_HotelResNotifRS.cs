using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rs
{
    [XmlRoot(ElementName = "OTA_HotelResNotifRS", Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public class OTA_HotelResNotifRS
    {
        [XmlAttribute(AttributeName = "EchoToken")]
        private string echoToken;
        [XmlAttribute(AttributeName = "TimeStamp")]
        private string timeStamp;
        [XmlAttribute(AttributeName = "Version")]
        private string version;
        [XmlElement(ElementName = "Success")]
        private string success;
        [XmlElement(ElementName = "Errors")]
        private string error;
        [XmlElement(ElementName = "Warnings")]
        private string warnings;
        [XmlElement(ElementName = "HotelReservations")]
        private HotelReservationsrs hotelReservationsrs;

        public string EchoToken
        {
            get
            {
                return echoToken;
            }

            set
            {
                echoToken = value;
            }
        }

        public string TimeStamp
        {
            get
            {
                return timeStamp;
            }

            set
            {
                timeStamp = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Success
        {
            get
            {
                return success;
            }

            set
            {
                success = value;
            }
        }

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        public string Warnings
        {
            get
            {
                return warnings;
            }

            set
            {
                warnings = value;
            }
        }

        public HotelReservationsrs HotelReservationsrs
        {
            get
            {
                return hotelReservationsrs;
            }

            set
            {
                hotelReservationsrs = value;
            }
        }
    }
}