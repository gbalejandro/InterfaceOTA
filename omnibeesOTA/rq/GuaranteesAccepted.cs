using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class GuaranteesAccepted
    {
        [XmlElement(ElementName = "GuaranteeAccepted")]
        private List<GuaranteeAccepted> guaranteeAccepted;

        public List<GuaranteeAccepted> GuaranteeAccepted
        {
            get
            {
                return guaranteeAccepted;
            }

            set
            {
                guaranteeAccepted = value;
            }
        }
    }
}