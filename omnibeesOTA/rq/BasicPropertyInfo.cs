using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class BasicPropertyInfo
    {
        [XmlAttribute(AttributeName = "HotelCode")]
        private string hotelCode;
        [XmlAttribute(AttributeName = "ChainCode")]
        private string chainCode;

        public string HotelCode
        {
            get
            {
                return hotelCode;
            }

            set
            {
                hotelCode = value;
            }
        }

        public string ChainCode
        {
            get
            {
                return chainCode;
            }

            set
            {
                chainCode = value;
            }
        }
    }
}