using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class HotelReservationID
    {
        [XmlAttribute(AttributeName = "ResID_Type")]
        private string resID_Type;
        [XmlAttribute(AttributeName = "ResID_Value")]
        private string resID_Value;
        [XmlAttribute(AttributeName = "ResID_Source")]
        private string resID_Source;

        public string ResID_Type
        {
            get
            {
                return resID_Type;
            }

            set
            {
                resID_Type = value;
            }
        }

        public string ResID_Value
        {
            get
            {
                return resID_Value;
            }

            set
            {
                resID_Value = value;
            }
        }

        public string ResID_Source
        {
            get
            {
                return resID_Source;
            }

            set
            {
                resID_Source = value;
            }
        }
    }
}