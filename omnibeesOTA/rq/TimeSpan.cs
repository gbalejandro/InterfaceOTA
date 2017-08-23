using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class TimeSpan
    {
        [XmlAttribute(AttributeName = "Start")]
        private string start;
        [XmlAttribute(AttributeName = "End")]
        private string end;

        public string Start
        {
            get
            {
                return start;
            }

            set
            {
                start = value;
            }
        }

        public string End
        {
            get
            {
                return end;
            }

            set
            {
                end = value;
            }
        }
    }
}