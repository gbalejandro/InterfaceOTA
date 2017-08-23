using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RoomRates
    {
        [XmlElement(ElementName = "RoomRate")]
        private List<RoomRate> roomRate;

        public List<RoomRate> RoomRate
        {
            get
            {
                return roomRate;
            }

            set
            {
                roomRate = value;
            }
        }
    }
}