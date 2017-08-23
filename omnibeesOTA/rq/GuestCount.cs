using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class GuestCount
    {
        [XmlAttribute(AttributeName = "AgeQualifyingCode")]
        private int ageQualifyingCode;
        [XmlAttribute(AttributeName = "Count")]
        private int count;
        [XmlAttribute(AttributeName = "Age")]
        private int age;

        public int AgeQualifyingCode
        {
            get
            {
                return ageQualifyingCode;
            }

            set
            {
                ageQualifyingCode = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }
    }
}