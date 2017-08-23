using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Results
    {
        [XmlAttribute(AttributeName = "XID")]
        private string xID;

        public string XID
        {
            get
            {
                return xID;
            }

            set
            {
                xID = value;
            }
        }
    }
}