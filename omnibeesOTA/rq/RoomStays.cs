﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RoomStays
    {
        [XmlElement(ElementName = "RoomStay")]
        private List<RoomStay> roomStay;

        public List<RoomStay> RoomStay
        {
            get
            {
                return roomStay;
            }

            set
            {
                roomStay = value;
            }
        }
    }
}