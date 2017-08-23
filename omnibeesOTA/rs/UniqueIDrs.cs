using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rs
{
    public class UniqueIDrs
    {
        [XmlAttribute(AttributeName = "Type")]
        private string type;
        [XmlAttribute(AttributeName = "ID")]
        private string iD;

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }
    }
}