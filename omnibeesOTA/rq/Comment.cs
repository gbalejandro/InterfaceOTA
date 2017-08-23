using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Comment
    {
        [XmlElement(ElementName = "Text")]
        private Text text;
        [XmlAttribute(AttributeName = "GuestViewable")]
        private string guestViewable;

        public Text Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public string GuestViewable
        {
            get
            {
                return guestViewable;
            }

            set
            {
                guestViewable = value;
            }
        }
    }
}