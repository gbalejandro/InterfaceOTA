using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Customer
    {
        [XmlAttribute(AttributeName = "Birthday")]
        private string birthday;
        [XmlElement(ElementName = "PersonName")]
        private PersonName personName;
        [XmlElement(ElementName = "Telephone")]
        private Telephone telephone;
        [XmlElement(ElementName = "Email")]
        private string email;
        [XmlElement(ElementName = "Address")]
        private Address address;
        [XmlElement(ElementName = "PaymentForm")]
        private PaymentForm paymentForm;
        [XmlElement(ElementName = "CustLoyalty")]
        private List<CustLoyalty> custLoyalty;
        [XmlElement(ElementName = "Document")]
        private List<Document> document;

        public string Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
            }
        }

        public PersonName PersonName
        {
            get
            {
                return personName;
            }

            set
            {
                personName = value;
            }
        }

        public Telephone Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public Address Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public PaymentForm PaymentForm
        {
            get
            {
                return paymentForm;
            }

            set
            {
                paymentForm = value;
            }
        }

        public List<CustLoyalty> CustLoyalty
        {
            get
            {
                return custLoyalty;
            }

            set
            {
                custLoyalty = value;
            }
        }

        public List<Document> Document
        {
            get
            {
                return document;
            }

            set
            {
                document = value;
            }
        }
    }
}