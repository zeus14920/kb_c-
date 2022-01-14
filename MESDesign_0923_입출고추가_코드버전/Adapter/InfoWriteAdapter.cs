using MESDesign_code.DBO;
using MESDesign_code.Model;
using MESDesign_code.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESDesign_code.Adapter
{
    class InfoWriteAdapter
    {
        ThingSpeak ts = new ThingSpeak();

        Random r = new Random();
        string[] temp = { "15", "22", "38", "41", "57", "63", "77", "84", "92", "104" };
        string[] humi = { "15", "22", "38", "41", "57", "63", "77", "84", "92", "104" };
        string[] dust = { "15", "22", "38", "41", "57", "63", "77", "84", "92", "104" };
        
        public void writeHandler(object args)
        {
            string time = DateTime.Now.ToString("yyyy년MM월dd일 HH:mm:ss");
            string temp1 = temp[r.Next(10)];
            string humi1 = humi[r.Next(10)];
            string dust1 = dust[r.Next(10)];
            string finished = "0";
            string defective = ""+r.Next(10);
            finished = Convert.ToString(100 - int.Parse(defective));
            bool chk = ts.sendToThingSpeak(temp1, humi1, dust1, finished, defective);
            if (chk == true)
            {
                Console.WriteLine("{0} -> 데이터 전송 성공!",time);
            }
            else
            {
                Console.WriteLine("{0} -> 데이터 전송 실패!", time);
            }
            OraMgr.Instance.insertLineEnvDB(new LineEnvData(time, temp1, humi1, dust1));
            OraMgr.Instance.insertLineManagDB(new LineProduce(time, finished, defective));
            return;
        }
    }
}
