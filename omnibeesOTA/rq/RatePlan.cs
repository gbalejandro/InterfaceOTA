using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class RatePlan
    {
        [XmlAttribute(AttributeName = "RatePlanCode")]
        private string ratePlanCode;
        [XmlElement(ElementName = "Guarantee")]
        private Guarantee guarantee;
        [XmlElement(ElementName = "MealsIncluded")]
        private MealsIncluded mealsIncluded;

        public string RatePlanCode
        {
            get
            {
                return ratePlanCode;
            }

            set
            {
                ratePlanCode = value;
            }
        }

        public Guarantee Guarantee
        {
            get
            {
                return guarantee;
            }

            set
            {
                guarantee = value;
            }
        }

        public MealsIncluded MealsIncluded
        {
            get
            {
                return mealsIncluded;
            }

            set
            {
                mealsIncluded = value;
            }
        }
    }
}