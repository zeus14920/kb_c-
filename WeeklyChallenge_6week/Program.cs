using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyChallenge_6week
{
    public class playsInfo
    {
        int pNum;
        int pWeight;
        string[] pHead2head;
        double pWinRate;
        int hWinNum;
        int result;

        public playsInfo(int pNum, int pWeight, string[] pHead2head, double pWinRate, int hWinNum, int result)
        {
            this.pNum = pNum;
            this.pWeight = pWeight;
            this.pHead2head = pHead2head;
            this.pWinRate = pWinRate;
            this.hWinNum = hWinNum;
            this.result = result;
        }

        public int PNum { get => pNum; set => pNum = value; }
        public int PWeight { get => pWeight; set => pWeight = value; }
        public string[] PHead2head { get => pHead2head; set => pHead2head = value; }
        public double PWinRate { get => pWinRate; set => pWinRate = value; }
        public int HWinNum { get => hWinNum; set => hWinNum = value; }
        public int Result { get => result; set => result = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            /*var winLose = "WL";
            //var wLoseArr = new char[1];
            //int[] weights = new int[r.Next(2,1001)];
            int[] weights = new int[r.Next(2, 5)];
            for (int i = 0; i < weights.Length; i++)
            {
                weights[i] = r.Next(45, 151);
            }
            string[] head2head = new string[weights.Length];
            string[,] head2headArr = new string[weights.Length,1];*/

            /*for (int j = 0; j < weights.Length; j++)
            {
                //head2headArr[j, 0] = Convert.ToString(winLose[r.Next(winLose.Length)]);
                for (int l = weights.Length; l >= 0; l--)
                {
                    if (j == l)
                    {
                        head2headArr[j, 0] = "N";
                    }
                    else
                    {
                        head2headArr[j, 0] = Convert.ToString(winLose[r.Next(winLose.Length)]);
                    }

                }
                Console.WriteLine(head2headArr[j, 0]);
            }*/

            /*for(int n = 0; n < weights.Length; n++)
            {
                head2head[n] += head2headArr[n, 0];
            }*/
            int[] weights = { 50, 82, 75, 120 };
            string[] head2head = { "NLWL", "WNLL", "LWNW", "WWLN" };
            /*int[] weights = { 145, 92, 86 };
            string[] head2head = { "NLW", "WNL", "LWN" };*/
            /*int[] weights = { 60, 70, 60 };
            string[] head2head = { "NNN", "NNN", "NNN" };*/
            /*int[] weights = { 145, 64, 84, 99, 46 };
            string[] head2head = { "NNNNN", "NNNNN", "NNNNN" };*/

            Solution solu = new Solution();
            solu.solution(weights, head2head);
            Console.WriteLine();
        }
    }
    public class Solution
    {
        public int[] solution(int[] weights, string[] head2head)
        {
            int[] weigh = weights;
            string[] head = head2head;
            string[,] head2 = new string[weigh.Length, weigh.Length];
            string[] head3 = new string[weigh.Length];
            double[] winRate = new double[weigh.Length];
            int[] hWinNum = new int[weigh.Length];
            int count = 0;
            int count2 = 0;
            int num = 0;
            int[] answer = new int[weigh.Length];
            List<playsInfo> pInfo = new List<playsInfo>();

            for (int i = 0; i < weights.Length; i++)
            {
                string str = head[i];
                for (int j = 0; j < weigh.Length; j++)
                {
                    head2[i, j] = str.Substring(j, 1);
                    head3[j] = head2[i, j];
                }

                for (int l = 0; l < weigh.Length; l++)
                {
                    if (head2[i, l] == "W")
                    {
                        count += 1;
                    }
                    else if (head2[i, l] == "L")
                    {
                        count2 += 1;
                    }
                    else if (head2[i, l] == "N")
                    {
                        count += 0;
                        count2 += 0;
                    }
                }
                winRate[i] = Math.Truncate((double)count / (count + count2) * 10000);
                if (winRate[i].Equals(double.NaN) == true)
                {
                    winRate[i] = 0;
                }
                count = 0;
                count2 = 0;
            }

            for (int n = 0; n < weigh.Length; n++)
            {
                for (int m = 0; m < weigh.Length; m++)
                {
                    if (head2[n, m] == "W" && head2[m, n] == "L")
                    {
                        if (weigh[n] < weigh[m])
                        {
                            count += 1;
                        }
                        else
                        {
                            count += 0;
                        }

                    }
                    else if (head2[n, m] == "N" && head2[m, n] == "N")
                    {
                        count += 0;
                    }
                }
                hWinNum[n] = count;
                count = 0;
                pInfo.Add(new playsInfo(n + 1, weigh[n], head3, winRate[n], hWinNum[n], n + 1));
            }

            for (int o = 0; o < weigh.Length; o++)
            {
                for (int p = 0; p < weigh.Length; p++)
                {
                    if (o == p)
                    {
                        continue;
                    }
                    else if (pInfo[o].PWinRate < pInfo[p].PWinRate && pInfo[o].Result < pInfo[p].Result)
                    {
                        num = pInfo[p].Result;
                        pInfo[p].Result = pInfo[o].Result;
                        pInfo[o].Result = num;
                    }
                    else if (pInfo[o].PWinRate > pInfo[p].PWinRate && pInfo[o].Result > pInfo[p].Result)
                    {
                        num = pInfo[o].Result;
                        pInfo[o].Result = pInfo[p].Result;
                        pInfo[p].Result = num;
                    }
                    else if (pInfo[o].PWinRate == pInfo[p].PWinRate)
                    {
                        if (pInfo[o].HWinNum < pInfo[p].HWinNum && pInfo[o].Result < pInfo[p].Result)
                        {
                            num = pInfo[p].Result;
                            pInfo[p].Result = pInfo[o].Result;
                            pInfo[o].Result = num;
                        }
                        else if (pInfo[o].HWinNum > pInfo[p].HWinNum && pInfo[o].Result > pInfo[p].Result)
                        {
                            num = pInfo[o].Result;
                            pInfo[o].Result = pInfo[p].Result;
                            pInfo[p].Result = num;
                        }
                        else if (pInfo[o].HWinNum == pInfo[p].HWinNum)
                        {
                            if (pInfo[o].PWeight < pInfo[p].PWeight && pInfo[o].Result < pInfo[p].Result)
                            {
                                num = pInfo[p].Result;
                                pInfo[p].Result = pInfo[o].Result;
                                pInfo[o].Result = num;
                            }
                            else if (pInfo[o].PWeight > pInfo[p].PWeight && pInfo[o].Result > pInfo[p].Result)
                            {
                                num = pInfo[o].Result;
                                pInfo[o].Result = pInfo[p].Result;
                                pInfo[p].Result = num;
                            }
                            else if (pInfo[o].PWeight == pInfo[p].PWeight)
                            {
                                if (pInfo[o].PNum < pInfo[p].PNum && pInfo[o].Result < pInfo[p].Result)
                                {
                                    continue;
                                }
                                else if (pInfo[o].PNum < pInfo[p].PNum && pInfo[o].Result > pInfo[p].Result)
                                {
                                    num = pInfo[o].Result;
                                    pInfo[o].Result = pInfo[p].Result;
                                    pInfo[p].Result = num;
                                }
                            }
                        }
                    }
                }
            }
            for(int q = 0; q < weigh.Length; q++)
            {
                answer[(pInfo[q].Result-1)] = pInfo[q].PNum;
            }
            return answer;
        }
    }
}