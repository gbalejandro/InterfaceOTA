using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class HotelReservations
    {
        [XmlElement(ElementName = "HotelReservation")]
        private List<HotelReservation> hotelReservation;

        public List<HotelReservation> HotelReservation
        {
            get
            {
                return hotelReservation;
            }

            set
            {
                hotelReservation = value;
            }
        }
    }
}