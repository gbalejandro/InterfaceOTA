using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rs
{
    public class HotelReservationsrs
    {
        [XmlElement(ElementName = "HotelReservation")]
        private HotelReservationrs hotelReservationrs;

        //public HotelReservationsrs(HotelReservationrs hotelReservationrs)
        //{
        //    this.HotelReservationrs = hotelReservationrs;
        //}

        public HotelReservationrs HotelReservationrs
        {
            get
            {
                return hotelReservationrs;
            }

            set
            {
                hotelReservationrs = value;
            }
        }
    }
}