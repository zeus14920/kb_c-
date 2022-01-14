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
        // Thread.sleep(20000);
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
            //string response = string.Empty;
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
                        //response += Encoding.ASCII.GetString(buf, 0, count);
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
            string url = "https://api.thingspeak.com/channels/1498600/feeds.json?api_key=Z8QTE2C1D3QJZLG5&results=1";
            WebClient webClient = new WebClient();
            var date = webClient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(date);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            List<LineEnvData> list = new List<LineEnvData>();

            // Console.WriteLine("채널 정보: " + feed.channel.name);
            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string temp1 = feeds[i].field1;
                string humi1 = feeds[i].field2;
                string temp2 = feeds[i].field3;
                string humi2 = feeds[i].field4;

                list.Add(new LineEnvData(time, temp1, humi1, temp2, humi2));

                /*
                Console.WriteLine("시간: " + time);
                Console.WriteLine("부품 1라인 온도: " + temp1 + " ℃");
                Console.WriteLine("부품 1라인 습도: " + humi1 + " %");
                Console.WriteLine("부품 2라인 온도: " + temp2 + " ℃");
                Console.WriteLine("부품 2라인 습도: " + humi2 + " %");

                Console.WriteLine("[부품 라인 모니터링 정보]");
                int nTemp1 = Convert.ToInt32(temp1);
                if (nTemp1 < 50)
                {
                    Console.WriteLine("부품 1라인 히터 가동중입니다.");
                }
                else
                {
                    Console.WriteLine("부품 1라인 에어컨 가동중입니다.");
                }
                Console.WriteLine("==================================");
                */
            }
            return list;
        }
    }

    class ThingSpeakTimer
    {
        Timer timer;

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
