using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class DirectBill
    {
        [XmlElement(ElementName = "Telephone")]
        private Telephone telephone;
        [XmlElement(ElementName = "Email")]
        private string email;
        [XmlElement(ElementName = "Address")]
        private Address address;
    }
}