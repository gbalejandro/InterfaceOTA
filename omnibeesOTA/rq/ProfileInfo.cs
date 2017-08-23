using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class ProfileInfo
    {
        [XmlElement(ElementName = "Profile")]
        private Profile profile;
        [XmlElement(ElementName = "UniqueID")]
        private UniqueID uniqueID;

        public Profile Profile
        {
            get
            {
                return profile;
            }

            set
            {
                profile = value;
            }
        }

        public UniqueID UniqueID
        {
            get
            {
                return uniqueID;
            }

            set
            {
                uniqueID = value;
            }
        }
    }
}