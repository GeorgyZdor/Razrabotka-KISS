using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    internal class SportsSect
    {
        int Time;
        double Speed;
        int Time2;

        public SportsSect()
        {
            Speed = 50;
            Time = 20;
        }
        public void setTime(int time2)
        {
            this.Time2 = time2;
        }

        public double CalculateTime()
        {
            double Distance = Time * Speed;
            return Distance;
        }

        public double CalculateTime2()
        {
            double Distance2 = Time2 * Speed;
            return Distance2;
        }
    }
}