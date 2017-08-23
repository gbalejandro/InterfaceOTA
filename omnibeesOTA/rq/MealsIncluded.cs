using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace omnibeesOTA.rq
{
    public class MealsIncluded
    {
        [XmlAttribute(AttributeName = "MealPlanIndicator")]
        private string mealPlanIndicator;
        [XmlAttribute(AttributeName = "MealPlanCodes")]
        private int mealPlanCodes;

        public string MealPlanIndicator
        {
            get
            {
                return mealPlanIndicator;
            }

            set
            {
                mealPlanIndicator = value;
            }
        }

        public int MealPlanCodes
        {
            get
            {
                return mealPlanCodes;
            }

            set
            {
                mealPlanCodes = value;
            }
        }
    }
}