using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class ServiceRPHs
    {
        [XmlElement(ElementName = "ServiceRPH")]
        private List<ServiceRPH> serviceRPH;

        public List<ServiceRPH> ServiceRPH
        {
            get
            {
                return serviceRPH;
            }

            set
            {
                serviceRPH = value;
            }
        }
    }
}