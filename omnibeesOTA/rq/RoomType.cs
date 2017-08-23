using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RoomType
    {
        [XmlAttribute]
        private string roomTypeCode;

        public string RoomTypeCode
        {
            get
            {
                return roomTypeCode;
            }

            set
            {
                roomTypeCode = value;
            }
        }
    }
}