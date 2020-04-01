using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalSkillsMentorship
{
    class _3_CalculateMinClockAngle
    {
        // March 25, 2020

        // Given a four-digit integer ranging from 0000 to 2359,
        // write a method that will calculate the smallest angle made by
        // the hour hand and the minute hand of an analog clock.

        // Assume that the hour hand will remain on the hour.
        // Assume there are no seconds.

        // For example, at 0345, the angle will be 180 degrees

        // Things to do!!!
        //  - Display an error message to if user enters number greater than 2359 or a negative number
        //  - Find precise angles between hands, assuming every hand move by the second
        //  - Add a second hand and find the angle
        

        // Hour hand stays on number
        public int MinClockAngle(int time)
        {
            int hour = time / 100;
            int minute = time % 100;

            if (time < 0 || time > 2359)
            {
                throw new InvalidOperationException();
            }
            else if (minute > 60)
                throw new ArgumentOutOfRangeException();

            if (hour > 12)
                hour -= 12;

            int minAngle = Math.Abs((hour * 30) - (minute * 6));
            Console.WriteLine($"Actual angle:  {minAngle}");

            if (minAngle > 180)
                minAngle = 360 - minAngle;

            return minAngle;
        }

        // Hour hand moves with Minute hand
        public double PreciseMinClockAngle(int time)
        {
            int hour = time / 100;
            int minute = time % 100;

            if (time < 0 || time > 2359)
            {
                throw new InvalidOperationException();
            }
            else if (minute > 60)
                throw new ArgumentOutOfRangeException();

            if (hour > 12)
                hour -= 12;

            double minAngle = Math.Abs(((hour * 30) + (minute / 2)) - (minute * 6));
            Console.WriteLine($"Actual angle:  {minAngle}");

            if (minAngle > 180)
                minAngle = 360 - minAngle;

            return minAngle;
        }

    } // _3_CalculateMinClockAngle class

} // TechnicalSkillsMentorship namespace
