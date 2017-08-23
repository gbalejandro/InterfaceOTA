using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    [XmlRoot(Namespace = "omnibeesOTA.rq")]
    public class UniqueID
    {
        [XmlAttribute(AttributeName = "Type")]
        private string type;
        [XmlAttribute(AttributeName = "ID")]
        private string iD;
        [XmlAttribute(AttributeName = "ID_Context")]
        private string iD_Context;

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

        public string ID_Context
        {
            get
            {
                return iD_Context;
            }

            set
            {
                iD_Context = value;
            }
        }
    }
}