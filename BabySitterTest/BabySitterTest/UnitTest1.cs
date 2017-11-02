using System;
using BabySitter;
using Microsoft.VisualStudio.TestTools.UnitTesting;




namespace BabySitterTest
{
    [TestClass]
    public class BabySitterUInitTest
    {

        BabySitterClass bs = new BabySitterClass ();
        DateTime starttime, endtime;

        DateTime now = DateTime.Now;
        [TestMethod]
        public void TestBabySitterStartTime()
        {
           //validating start time 
            starttime = new DateTime(now.Year, now.Month, now.Day, 18, 30, 0);
            bool isstarttimevalid = bs.ValidateStartTime(starttime);
            Assert.AreEqual(true, isstarttimevalid);

        }
        [TestMethod]
        public void TestBabySitterEndTime()
        {
            //validating end time
            endtime = new DateTime(now.Year, now.Month, now.Day, 22, 30, 0);
            bool isendtimevalid = bs.ValidateEndTime(endtime);
            Assert.AreEqual(true, isendtimevalid);

        }
        [TestMethod]
        public void ValidateBedTime()
        {
            // validate bed time is not earlier than start time
            DateTime bedtime = new DateTime(now.Year, now.Month, now.Day, 22, 0, 0);
            bool isbedtimevalid = bs.ValidateBedTime(bedtime);
            Assert.AreEqual(true, isbedtimevalid);

        }
        [TestMethod]
        public void ValidateMidTime()
        {
            //validate midnight time is not earlier then start time.
            DateTime midtime = new DateTime(now.Year, now.Month, now.Day, 1, 0, 0);
            bool ismidtimevalid = bs.ValidateMidTime(midtime);
            Assert.AreEqual(true, ismidtimevalid);

        }
        
       
    }
}
