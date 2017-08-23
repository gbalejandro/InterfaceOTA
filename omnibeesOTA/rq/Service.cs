using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Service
    {
        [XmlAttribute(AttributeName = "ServicePricingType")]
        private string servicePricingType;
        [XmlAttribute(AttributeName = "ServiceRPH")]
        private string serviceRPH;
        [XmlAttribute(AttributeName = "Inclusive")]
        private string inclusive;
        [XmlAttribute(AttributeName = "Quantity")]
        private string quantity;
        [XmlAttribute(AttributeName = "ID")]
        private string iD;
        [XmlAttribute(AttributeName = "Type")]
        private string type;
        [XmlAttribute(AttributeName = "ID_Type")]
        private string iD_Type;
        [XmlAttribute(AttributeName = "ID_Context")]
        private string iD_Context;
        [XmlElement(ElementName = "Price")]
        private Price price;
        [XmlElement(ElementName = "ServiceDetails")]
        private ServiceDetails serviceDetails;

        public string ServicePricingType
        {
            get
            {
                return servicePricingType;
            }

            set
            {
                servicePricingType = value;
            }
        }

        public string ServiceRPH
        {
            get
            {
                return serviceRPH;
            }

            set
            {
                serviceRPH = value;
            }
        }

        public string Inclusive
        {
            get
            {
                return inclusive;
            }

            set
            {
                inclusive = value;
            }
        }

        public string Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        public string ID
        {
            get
            {
                return iD;
            }

            set
            {
                iD = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string ID_Type
        {
            get
            {
                return iD_Type;
            }

            set
            {
                iD_Type = value;
            }
        }

        public string ID_Context
        {
            get
            {
                return iD_Context;
            }

            set
            {
                iD_Context = value;
            }
        }

        public Price Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public ServiceDetails ServiceDetails
        {
            get
            {
                return serviceDetails;
            }

            set
            {
                serviceDetails = value;
            }
        }
    }
}