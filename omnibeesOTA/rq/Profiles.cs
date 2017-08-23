using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Profiles
    {
        [XmlElement(ElementName = "ProfileInfo")]
        private List<ProfileInfo> profileInfo;

        public List<ProfileInfo> ProfileInfo
        {
            get
            {
                return profileInfo;
            }

            set
            {
                profileInfo = value;
            }
        }
    }
}