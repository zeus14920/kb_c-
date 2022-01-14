using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyChallenge_6week
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*int[] weights = { 50, 82, 75, 120 };
            string[] head2head = { "NLWL", "WNLL", "LWNW", "WWLN" };*/
            /*int[] weights = { 145, 92, 86 };
            string[] head2head = { "NLW", "WNL", "LWN" };*/
            int[] weights = { 60, 70, 60 };
            string[] head2head = { "NNN", "NNN", "NNN" };

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
            int[] pNum = new int[weigh.Length];
            int[] answer = new int[weigh.Length];
            int[] result = new int[weigh.Length];
            int num = 0;
            for(int s = 0; s < weigh.Length; s++)
            {
                pNum[s] = s + 1;
            }

            // 승률 계산
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
                winRate[i] = (double)count / (count + count2);
                if (winRate[i].Equals(double.NaN) == true)
                {
                    winRate[i] = 0;
                }
                count = 0;
                count2 = 0;
            }

            // 무거운 사람 이긴 횟수
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
                    else if(head2[n, m] == "L" && head2[m, n] == "W")
                    {
                        if(weigh[n] < weigh[m])
                        {
                            count += 0;
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
            }
            for(int t = 0; t < weigh.Length; t++)
            {
                result[t] = t + 1;
            }

            for (int o = 0; o < weigh.Length; o++)
            {
                for (int p = 0; p < weigh.Length; p++)
                {
                    if(winRate[o] < winRate[p] && result[o] < result[p])
                    {
                        num = result[p];
                        result[p] = result[o];
                        result[o] = num;
                    }
                    else if(winRate[o] > winRate[p] && result[o] > result[p])
                    {
                        num = result[o];
                        result[o] = result[p];
                        result[p] = num;
                    }
                    else if(winRate[o] == winRate[p])
                    {
                        if(hWinNum[o]<hWinNum[p] && result[o] < result[p])
                        {
                            num = result[p];
                            result[p] = result[o];
                            result[o] = num;
                        }
                        else if(hWinNum[o]>hWinNum[p] && result[o] > result[p])
                        {
                            num = result[o];
                            result[o] = result[p];
                            result[p] = num;
                        }
                        else if(hWinNum[o] == hWinNum[p])
                        {
                            if(weigh[o]<weigh[p] && result[o] < result[p])
                            {
                                num = result[p];
                                result[p] = result[o];
                                result[o] = num;
                            }
                            else if(weigh[o]>weigh[p] && result[o] > result[p])
                            {
                                num = result[o];
                                result[o] = result[p];
                                result[p] = num;
                            }
                            else if( weigh[o] == weigh[p])
                            {
                                if(pNum[o]<pNum[p] && result[o] > result[p])
                                {
                                    num = result[o];
                                    result[o] = result[p];
                                    result[p] = num;
                                }
                                else if(pNum[o]>pNum[p] && result[o] < result[p])
                                {
                                    num = result[p];
                                    result[p] = result[o];
                                    result[o] = num;
                                }
                            }
                        }
                    }
                }
            }
            for(int u = 0,w=1; u < weigh.Length; u++,w++)
            {
                for (int v = 0; v < weigh.Length; v++)
                {
                    if (result[v] == w)
                    {
                        answer[u] = pNum[v];
                        break;
                    }
                }
            }
            return answer;
        }
    }
}