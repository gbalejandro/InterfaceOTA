using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rs
{
    public class HotelReservationrs
    {
        [XmlElement(ElementName = "ResGlobalInfo")]
        private ResGlobalInfors resGlobalInfo;
        [XmlElement(ElementName = "UniqueIDrs")]
        private UniqueIDrs uniqueID;

        public ResGlobalInfors ResGlobalInfo
        {
            get
            {
                return resGlobalInfo;
            }

            set
            {
                resGlobalInfo = value;
            }
        }

        public UniqueIDrs UniqueIDrs
        {
            get
            {
                return uniqueID;
            }

            set
            {
                uniqueID = value;
            }
        }

        //public HotelReservationrs(ResGlobalInfors resGlobalInfo, rs.UniqueID uniqueID)
        //{
        //    this.ResGlobalInfo = resGlobalInfo;
        //    this.UniqueID = uniqueID;
        //}
    }
}