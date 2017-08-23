using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class PaymentForm
    {
        [XmlElement(ElementName = "DirectBill")]
        private DirectBill directBill;

        public DirectBill DirectBill
        {
            get
            {
                return directBill;
            }

            set
            {
                directBill = value;
            }
        }
    }
}