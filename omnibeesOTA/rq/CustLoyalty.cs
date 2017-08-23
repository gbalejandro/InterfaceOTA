using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class CustLoyalty
    {
        [XmlAttribute(AttributeName = "MembershipID")]
        private string membershipID;

        public string MembershipID
        {
            get
            {
                return membershipID;
            }

            set
            {
                membershipID = value;
            }
        }
    }
}