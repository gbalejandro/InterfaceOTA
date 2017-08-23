using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    [XmlRoot(ElementName = "POS")]
    public class Source
    {
        [XmlAttribute]
        private string pseudoCityCode;
        [XmlElement(ElementName = "BookingChannel")]
        private BookingChannel bookingChannel;

        public string PseudoCityCode
        {
            get
            {
                return pseudoCityCode;
            }

            set
            {
                pseudoCityCode = value;
            }
        }

        public BookingChannel BookingChannel
        {
            get
            {
                return bookingChannel;
            }

            set
            {
                bookingChannel = value;
            }
        }
    }
}