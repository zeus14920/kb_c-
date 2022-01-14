using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace iot_myself
{
    class mTime
    {
        Timer timer;

        public mTime(Timer timer)
        {
            this.timer = timer;
        }

        public void tStop()
        {
            timer.Dispose();
        }
    }
}
