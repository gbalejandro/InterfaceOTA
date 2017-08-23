using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class SeriesCode
    {
        [XmlElement(ElementName = "PlainText")]
        private string plainText;

        public string PlainText
        {
            get
            {
                return plainText;
            }

            set
            {
                plainText = value;
            }
        }
    }
}