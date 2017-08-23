using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class CompanyInfo
    {
        [XmlElement(ElementName = "CompanyName")]
        private CompanyName companyName;
        [XmlElement(ElementName = "AddressInfo")]
        private AddressInfo addressInfo;
        [XmlElement(ElementName = "TelephoneInfo")]
        private TelephoneInfo telephoneInfo;
        [XmlElement(ElementName = "BusinessLocale")]
        private BusinessLocale businessLocale;
        [XmlElement(ElementName = "Email")]
        private string email;

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

        public AddressInfo AddressInfo
        {
            get
            {
                return addressInfo;
            }

            set
            {
                addressInfo = value;
            }
        }

        public TelephoneInfo TelephoneInfo
        {
            get
            {
                return telephoneInfo;
            }

            set
            {
                telephoneInfo = value;
            }
        }

        public BusinessLocale BusinessLocale
        {
            get
            {
                return businessLocale;
            }

            set
            {
                businessLocale = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}