using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KSI.EntityClasses;

namespace PowerKSI.BL
{
    public class OfferingManager
    {
        public static bool CreateOffering(int offeringId, int offeringsemester, int offeringcourse, int instructor1, int instructor2, int capacity, string room, out string error)
        {
            error = String.Empty;

            var offering = new OfferingEntity()
            {
                Id=offeringId,
                SemesterId=offeringsemester,
                CourseId=offeringcourse,
                InstructorId=instructor1,
                Instructor2Id=instructor2,
                Capacity=capacity,
                RoomNumber=room

            };

            return offering.Save();
        }

        public static bool UpdateOffering(int offeringId, int offeringsemester, int offeringcourse, int instructor1, int instructor2, int capacity, string room, out string error)
        {
            error = String.Empty;

            var offering = new OfferingEntity(offeringId)
            {
                Id = offeringId,
                SemesterId = offeringsemester,
                CourseId = offeringcourse,
                InstructorId = instructor1,
                Instructor2Id = instructor2,
                Capacity = capacity,
                RoomNumber = room
            };

            return offering.Save();
        }

        public static bool DeleteOffering(int offeringId, out string error)
        {
            error = null;
            try
            {
                var toDelete = new OfferingEntity(offeringId);
                return toDelete.Delete();
            }
            catch (Exception ex)
            {
                error = "<h3>Oops...Something went wrong! Item can not be deleted!</h3> <b>Reason:</b>" + ex.Message;
                return false;
            }
        }
    }
}