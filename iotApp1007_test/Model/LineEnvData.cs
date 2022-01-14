﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iotApp1005.Model
{
    class LineEnvData
    {
        // S2933 오류
        // readonly 사용시 쓰기 불가능 예외처리
        string time;
        string temp1;
        string humi1;
        string temp2;
        string humi2;

        public LineEnvData(string time, string temp1, string humi1, string temp2, string humi2)
        {
            this.time = time;
            this.temp1 = temp1;
            this.humi1 = humi1;
            this.temp2 = temp2;
            this.humi2 = humi2;
        }

        // S2292 오류
        // 비주얼 스튜디오에서 만들어주는 코드 예외처리
        public string Time { get => time; set => time = value; }
        public string Temp1 { get => temp1; set => temp1 = value; }
        public string Humi1 { get => humi1; set => humi1 = value; }
        public string Temp2 { get => temp2; set => temp2 = value; }
        public string Humi2 { get => humi2; set => humi2 = value; }
    }
}
