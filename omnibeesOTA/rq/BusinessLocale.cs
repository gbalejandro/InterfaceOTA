using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class BusinessLocale
    {
        [XmlElement(ElementName = "AddressLine")]
        private List<string> addressLine;
        [XmlElement(ElementName = "CityName")]
        private string cityName;
        [XmlElement(ElementName = "PostalCode")]
        private string postalCode;
        [XmlElement(ElementName = "StateProv")]
        private string stateProv;
        [XmlElement(ElementName = "CountryName")]
        private string countryName;

        public string Add1()
        {
            if (addressLine != null && addressLine[0].Length > 0)
            {
                return addressLine[0];
            }
            return "";
        }

        public string Add2()
        {
            if (addressLine != null && addressLine[1].Length > 1)
            {
                return addressLine[1];
            }
            return "";
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }

        public string PostalCode
        {
            get
            {
                return postalCode;
            }

            set
            {
                postalCode = value;
            }
        }

        public string StateProv
        {
            get
            {
                return stateProv;
            }

            set
            {
                stateProv = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }

            set
            {
                countryName = value;
            }
        }
    }
}