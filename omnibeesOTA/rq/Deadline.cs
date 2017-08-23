using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class Deadline
    {
        [XmlAttribute(AttributeName = "OffsetTimeUnit")]
        private string offsetTimeUnit;
        [XmlAttribute(AttributeName = "OffsetUnitMultiplier")]
        private string offsetUnitMultiplier;
        [XmlAttribute(AttributeName = "OffsetDropTime")]
        private string offsetDropTime;

        public string OffsetTimeUnit
        {
            get
            {
                return offsetTimeUnit;
            }

            set
            {
                offsetTimeUnit = value;
            }
        }

        public string OffsetUnitMultiplier
        {
            get
            {
                return offsetUnitMultiplier;
            }

            set
            {
                offsetUnitMultiplier = value;
            }
        }

        public string OffsetDropTime
        {
            get
            {
                return offsetDropTime;
            }

            set
            {
                offsetDropTime = value;
            }
        }
    }
}