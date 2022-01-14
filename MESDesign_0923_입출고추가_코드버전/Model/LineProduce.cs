using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Model
{
    class LineProduce
    {
        string time;
        string finished;
        string defective;

        public LineProduce(string time, string finished, string defective)
        {
            this.time = time;
            this.finished = finished;
            this.defective = defective;
        }

        public string Time { get => time; set => time = value; }
        public string Finished { get => finished; set => finished = value; }
        public string Defective { get => defective; set => defective = value; }
    }
}
