using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Price
    {
        [XmlElement(ElementName = "Total")]
        private Total total;

        public Total Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}