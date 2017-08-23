using omnibeesOTA.rq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class BookingChannel
    {
        [XmlElement(ElementName = "CompanyName")]
        private CompanyName companyName;

        public CompanyName CompanyName
        {
            get
            {
                return companyName;
            }

            set
            {
                companyName = value;
            }
        }
    }
}