using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Taxes
    {
        [XmlElement(ElementName = "TaxType")]
        private List<TaxType> taxType;

        public List<TaxType> TaxType
        {
            get
            {
                return taxType;
            }

            set
            {
                taxType = value;
            }
        }
    }
}