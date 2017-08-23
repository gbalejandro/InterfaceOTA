using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class ServiceRPH
    {
        [XmlAttribute(AttributeName = "RPH")]
        private string rPH;
        [XmlAttribute(AttributeName = "IsPerRoom")]
        private string isPerRoom;

        public string RPH
        {
            get
            {
                return rPH;
            }

            set
            {
                rPH = value;
            }
        }

        public string IsPerRoom
        {
            get
            {
                return isPerRoom;
            }

            set
            {
                isPerRoom = value;
            }
        }
    }
}