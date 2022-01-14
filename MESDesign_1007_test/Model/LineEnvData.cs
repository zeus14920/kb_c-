using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Model
{
    class LineEnvData
    {
        string time;
        string temp1;
        string humi1;
        string dust1;

        public LineEnvData(string time, string temp1, string humi1, string dust1)
        {
            this.time = time;
            this.temp1 = temp1;
            this.humi1 = humi1;
            this.dust1 = dust1;
        }

        // S2292 오류
        // 프로그램 자체 코드 예외처리
        public string Time { get => time; set => time = value; }
        public string Temp1 { get => temp1; set => temp1 = value; }
        public string Humi1 { get => humi1; set => humi1 = value; }
        public string Dust1 { get => dust1; set => dust1 = value; }
    }
}
