using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Address
    {
        [XmlAttribute(AttributeName = "UseType")]
        private string useType;
        [XmlElement(ElementName = "AddressLine")]
        private List<string> addressLine;
        [XmlElement(ElementName = "CityName")]
        private string cityName;
        [XmlElement(ElementName = "PostalCode")]
        private string postalCode;
        [XmlElement(ElementName = "StateProv")]
        private StateProv stateProv;
        [XmlElement(ElementName = "CountryName")]
        private CountryName countryName;

        public string UseType
        {
            get
            {
                return useType;
            }

            set
            {
                useType = value;
            }
        }

        public List<string> AddressLine
        {
            get
            {
                return addressLine;
            }

            set
            {
                addressLine = value;
            }
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

        public StateProv StateProv
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

        public CountryName CountryName
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