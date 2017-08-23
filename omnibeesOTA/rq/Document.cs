using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Document
    {
        [XmlAttribute(AttributeName = "DocID")]
        private string docID;

        public string DocID
        {
            get
            {
                return docID;
            }

            set
            {
                docID = value;
            }
        }
    }
}