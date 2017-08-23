using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class PersonName
    {
        [XmlAttribute(AttributeName = "NameType")]
        private string nameType;
        [XmlElement(ElementName = "NamePrefix")]
        private string namePrefix;
        [XmlElement(ElementName = "GivenName")]
        private string givenName;
        [XmlElement(ElementName = "Surname")]
        private string surname;

        public string NameType
        {
            get
            {
                return nameType;
            }

            set
            {
                nameType = value;
            }
        }

        public string NamePrefix
        {
            get
            {
                return namePrefix;
            }

            set
            {
                namePrefix = value;
            }
        }

        public string GivenName
        {
            get
            {
                return givenName;
            }

            set
            {
                givenName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }
    }
}