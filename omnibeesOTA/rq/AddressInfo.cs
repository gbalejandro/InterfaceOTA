using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class AddressInfo
    {
        [XmlElement(ElementName = "AddressLine")]
        private List<string> addressLine;
        [XmlElement(ElementName = "CityName")]
        private string cityName;
        [XmlElement(ElementName = "Country")]
        private string country;

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

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }
    }
}