using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class CompanyName
    {
        [XmlAttribute(AttributeName = "Code")]
        private string code;
        [XmlAttribute(AttributeName = "CodeContext")]
        private string codeContext;
        [XmlText]
        private string value;

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string CodeContext
        {
            get
            {
                return codeContext;
            }

            set
            {
                codeContext = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}