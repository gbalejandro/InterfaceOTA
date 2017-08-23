using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class POS
    {
        [XmlElement(ElementName = "Source")]
        private List<Source> source;

        public List<Source> Source
        {
            get
            {
                return source;
            }

            set
            {
                source = value;
            }
        }
    }
}