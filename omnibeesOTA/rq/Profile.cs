using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Profile
    {
        [XmlElement(ElementName = "Customer")]
        private Customer customer;
        [XmlElement(ElementName = "CompanyInfo")]
        private CompanyInfo companyInfo;
        [XmlElement(ElementName = "TPA_Extensions")]
        private TPA_Extensions tPA_Extensions;

        public Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public CompanyInfo CompanyInfo
        {
            get
            {
                return companyInfo;
            }

            set
            {
                companyInfo = value;
            }
        }

        public TPA_Extensions TPA_Extensions
        {
            get
            {
                return tPA_Extensions;
            }

            set
            {
                tPA_Extensions = value;
            }
        }
    }
}