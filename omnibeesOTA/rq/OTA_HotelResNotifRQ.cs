using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    [XmlRoot]
    public class OTA_HotelResNotifRQ
    {
        [XmlAttribute(AttributeName = "TimeStamp")]
        private string timeStamp;
        [XmlAttribute(AttributeName = "Version")]
        private string version;
        [XmlAttribute(AttributeName = "EchoToken")]
        private string echoToken;
        [XmlElement(ElementName = "HotelReservations")]
        private HotelReservations hotelReservations;

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

        public HotelReservations HotelReservations
        {
            get
            {
                return hotelReservations;
            }

            set
            {
                hotelReservations = value;
            }
        }
    }
}