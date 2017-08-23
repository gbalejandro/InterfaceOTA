using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Telephone
    {
        [XmlAttribute(AttributeName = "PhoneNumber")]
        private string phoneNumber;
        [XmlAttribute(AttributeName = "PhoneTechType")]
        private string phoneTechType;
        [XmlAttribute(AttributeName = "PhoneUseType")]
        private string phoneUseType;
        [XmlAttribute(AttributeName = "CountryAccessCode")]
        private string countryAccessCode;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string PhoneTechType
        {
            get
            {
                return phoneTechType;
            }

            set
            {
                phoneTechType = value;
            }
        }

        public string PhoneUseType
        {
            get
            {
                return phoneUseType;
            }

            set
            {
                phoneUseType = value;
            }
        }

        public string CountryAccessCode
        {
            get
            {
                return countryAccessCode;
            }

            set
            {
                countryAccessCode = value;
            }
        }
    }
}