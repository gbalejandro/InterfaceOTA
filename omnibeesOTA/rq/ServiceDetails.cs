using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class ServiceDetails
    {
        [XmlElement(ElementName = "ServiceDescription")]
        private ServiceDescription serviceDescription;

        public ServiceDescription ServiceDescription
        {
            get
            {
                return serviceDescription;
            }

            set
            {
                serviceDescription = value;
            }
        }
    }
}