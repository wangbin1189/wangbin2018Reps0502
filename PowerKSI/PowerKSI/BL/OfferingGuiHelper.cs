using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using KSI.DaoClasses;
using KSI.EntityClasses;
using KSI.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace PowerKSI.BL
{
    public class OfferingGuiHelper
    {
        public static OfferingEntity GetOffering(int offeringId)
        {
            var toReturn = new OfferingEntity(offeringId);
            return toReturn.IsNew ? null : toReturn;
        }
    }
}