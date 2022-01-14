using iotApp1005.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace iotApp1005.Util
{
    class ThingSpeak
    {
        // 20초 마다 랜덤하게 데이터를 클라우드 서버로 전송
        // S1075 오류
        // url를 통해 사이트 접속 예외 처리
        const string url = "http://api.thingspeak.com/";
        const string APIKEY_WRITE = "EDZQ4ICEHBP6SVU4";

        public bool sendDateToThingSpeak(string field1, string field2, string field3,
            string field4, string field5, string field6, string field7, string field8)
        {
            string sbQS = string.Empty;
            // http 통신 
            sbQS += url + "update?key=" + APIKEY_WRITE;
            if (field1 != null)
            {
                sbQS += "&field1=" + HttpUtility.UrlEncode(field1);
            }
            if (field2 != null)
            {
                sbQS += "&field2=" + HttpUtility.UrlEncode(field2);
            }
            if (field3 != null)
            {
                sbQS += "&field3=" + HttpUtility.UrlEncode(field3);
            }
            if (field4 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field5 != null)
            {
                sbQS += "&field5=" + HttpUtility.UrlEncode(field5);
            }
            if (field6 != null)
            {
                sbQS += "&field6=" + HttpUtility.UrlEncode(field6);
            }
            if (field7 != null)
            {
                sbQS += "&field7=" + HttpUtility.UrlEncode(field7);
            }
            if (field8 != null)
            {
                sbQS += "&field8=" + HttpUtility.UrlEncode(field8);
            }
            int res = Convert.ToInt32(postToThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }

        public string postToThingSpeak(string str)
        {
            StringBuilder strBuil = new StringBuilder();
            byte[] buf = new byte[8192];

            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(str);
            HttpWebResponse webResponse = (HttpWebResponse)myRequest.GetResponse();

            try
            {
                Stream myResponse = webResponse.GetResponseStream();
                int count = 0;
                do
                {
                    count = myResponse.Read(buf, 0, buf.Length);
                    if (count != 0)
                    {
                        strBuil.Append(Encoding.ASCII.GetString(buf, 0, count));
                    }
                } while (count > 0);
                string response = strBuil.ToString();
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";
        }

        public List<LineEnvData> readThingSpeak()
        {
            // S1117 오류
            // url를 통해 사이트 접속함으로 예외처리
            string url = "https://api.thingspeak.com/channels/1498600/feeds.json?api_key=Z8QTE2C1D3QJZLG5&results=1";
            // S2930 오류
            // 객체를 생성하는 사용자 변수명 예외처리
            WebClient webClient = new WebClient();
            var date = webClient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(date);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            List<LineEnvData> list = new List<LineEnvData>();

            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string temp1 = feeds[i].field1;
                string humi1 = feeds[i].field2;
                string temp2 = feeds[i].field3;
                string humi2 = feeds[i].field4;

                list.Add(new LineEnvData(time, temp1, humi1, temp2, humi2));
            }
            return list;
        }
    }

    class ThingSpeakTimer
    {
        readonly Timer timer;

        public ThingSpeakTimer(Timer timer)
        {
            this.timer = timer;
        }

        ~ThingSpeakTimer()
        {
            stopTimer();
        }

        public void stopTimer()
        {
            timer.Dispose();
        }
    }
}
