using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Services
    {
        [XmlElement(ElementName = "Service")]
        private List<Service> service;

        public List<Service> Service
        {
            get
            {
                return service;
            }

            set
            {
                service = value;
            }
        }
    }
}