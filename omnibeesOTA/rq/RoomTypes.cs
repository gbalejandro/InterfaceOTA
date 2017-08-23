using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RoomTypes
    {
        [XmlElement(ElementName = "RoomType")]
        private List<RoomType> roomType;

        public List<RoomType> RoomType
        {
            get
            {
                return roomType;
            }

            set
            {
                roomType = value;
            }
        }
    }
}