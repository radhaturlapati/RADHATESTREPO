using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabySitter
{
    public class BabySitterClass
    {
        DateTime now = DateTime.Now;
        DateTime stime, etime, btime, mtime;
        TimeSpan ts;
        int result, bpay, mpay, epay, fullpay, hours = 0;
        bool returnval;
        public bool ValidateStartTime(DateTime st)
        {
            DateTime dtm = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0);
            stime = st;
            // check if start time is not earlier then 5 pm
            result = DateTime.Compare(st, dtm);
            if (result < 0)
                returnval = false;
            else
                returnval = true;
            return returnval;

        }
            
              
        public bool ValidateEndTime(DateTime et)
        {
            DateTime dtm = new DateTime(now.Year, now.Month, now.Day+1, 4, 0, 0);
            etime = et;

           result = DateTime.Compare(et, dtm);
         // check if end time is not later than 4 am
            if (result <= 0)
                returnval = true;
            else
                returnval = false;
            return returnval;
        }
        public bool ValidateBedTime(DateTime bt)
        {
            
            DateTime dtm = new DateTime(now.Year, now.Month, now.Day, 22, 0, 0);
            btime = bt;
            result = DateTime.Compare(bt, dtm);
            if (result ==  0)
            {
             // validate bed time and calculate pay accordingly.
                returnval = true;
                ts = btime - stime;
                hours = ts.Hours;
                bpay = hours * 12;
            }
            else
                returnval = false;
            return returnval;

        }
        public bool ValidateMidTime(DateTime mt)
        {
            DateTime dtm = new DateTime(now.Year, now.Month, now.Day, 1, 0, 0);
            mtime = mt;
            result = DateTime.Compare(mt, dtm);
            if (result == 0)
            {
                // validate midnight time and calculate the full payment until end time
                returnval = true;
                ts = mtime - btime;
                hours = ts.Hours;
                mpay = hours * 8;
                ts = etime - mtime;
                hours = ts.Hours;
                epay = hours * 16;
                fullpay = bpay + mpay + epay;
                Console.WriteLine(" Baby Sitter Per night amount :" + fullpay);

            }
            else
                returnval = false;
            return returnval;

        }

    }
}
