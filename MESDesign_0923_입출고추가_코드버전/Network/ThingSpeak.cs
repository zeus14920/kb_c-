using MESDesign_code.Model;
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

namespace MESDesign_code.Util
{
    class ThingSpeak
    {
        // 20초 마다 랜덤하게 데이터를 클라우드 서버로 전송
        // Thread.sleep(20000);
        const string url = "http://api.thingspeak.com/";
        const string APIKEY_WRITE = "YCMPC76WUFYNDKO8";

        public bool sendToThingSpeak(string field1, string field2, string field3, string field4, string field5)
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
            if (field3 != null)
            {
                sbQS += "&field4=" + HttpUtility.UrlEncode(field4);
            }
            if (field3 != null)
            {
                sbQS += "&field5=" + HttpUtility.UrlEncode(field5);
            }
            int res = Convert.ToInt32(postToThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }

        /*public bool sendLineDateToThingSpeak(string field4, string field5)
        {
            string sbQS = string.Empty;
            // http 통신 
            sbQS += url + "update?key=" + APIKEY_WRITE;
            if (field4 != null)
            {
                sbQS += "&field1=" + HttpUtility.UrlEncode(field4);
            }
            if (field5 != null)
            {
                sbQS += "&field2=" + HttpUtility.UrlEncode(field5);
            }
            int res = Convert.ToInt32(postToLineManagThingSpeak(sbQS));
            if (res <= 0)
            {
                return false;
            }
            return true;
        }
*/
        public string postToThingSpeak(string str)
        {
            string response = string.Empty;
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
                        response += Encoding.ASCII.GetString(buf, 0, count);
                    }
                } while (count > 0);
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";

        }

        /*public string postToLineManagThingSpeak(string str)
        {
            string response = string.Empty;
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
                        response += Encoding.ASCII.GetString(buf, 0, count);
                    }
                } while (count > 0);
                return response;
            }
            catch (WebException e)
            {
                Console.WriteLine("응답 에러: " + e.Message);
            }
            return "0";
        }*/

        public List<LineEnvData> readThingSpeak()
        {
            string url = "https://api.thingspeak.com/channels/1507534/feeds.json?api_key=QRIVH7E4Y9VGV8YG&results=1";
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
                string dust1 = feeds[i].field3;

                list.Add(new LineEnvData(time, temp1, humi1, dust1));
            }
            return list;
        }

        public List<LineProduce> readLineDateThingSpeak()
        {
            string url = "https://api.thingspeak.com/channels/1507534/feeds.json?api_key=QRIVH7E4Y9VGV8YG&results=1";
            WebClient webClient = new WebClient();
            var date = webClient.DownloadString(url);
            dynamic feed = JsonConvert.DeserializeObject<dynamic>(date);
            List<dynamic> feeds = feed.feeds.ToObject<List<dynamic>>();
            List<LineProduce> list = new List<LineProduce>();

            // Console.WriteLine("채널 정보: " + feed.channel.name);
            for (int i = 0; i < feeds.Count; i++)
            {
                string time = feeds[i].created_at;
                string finished = feeds[i].field4;
                string defective = feeds[i].field5;

                list.Add(new LineProduce(time, finished, defective));
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
