using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class TPA_Extensions
    {
        [XmlElement(ElementName = "VATNumber")]
        private string vATNumber;

        public string VATNumber
        {
            get
            {
                return vATNumber;
            }

            set
            {
                vATNumber = value;
            }
        }
    }
}