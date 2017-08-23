using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class TaxType
    {
        [XmlAttribute]
        private string percent;

        public string Percent
        {
            get
            {
                return percent;
            }

            set
            {
                percent = value;
            }
        }
    }
}