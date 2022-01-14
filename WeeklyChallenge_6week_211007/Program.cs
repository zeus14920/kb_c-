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
            int[] weights = { 145, 92, 86 };
            string[] head2head = { "NLW", "WNL", "LWN" };
            int[] ans = new int[weights.Length];
            /*int[] weights = { 60, 70, 60 };
            string[] head2head = { "NNW", "NNN", "LNN" };*/

            Solution solu = new Solution();
            solu.solution(weights, head2head);
            /*for (int i = 0; i < weights.Length; i++)
            {
                ans[i] = solu.solution(weights, head2head)[i];
                Console.WriteLine(ans[i]);
            }*/
            ans = solu.solution(weights, head2head);

            Console.WriteLine(ans);
        }
    }
    public class Solution
    {
        public int[] solution(int[] weights, string[] head2head)
        {
            int[] answer = new int[weights.Length];
            int[] pNum = new int[weights.Length];
            string[,] head = new string[weights.Length,weights.Length];
            double[] pWinRate = new double[weights.Length];
            int[] pHwin = new int[weights.Length];
            int[] result = new int[weights.Length];
            int count = 0;
            int round = 0;

            // 선수 번호 배정
            for(int a = 0; a < weights.Length; a++)
            {
                pNum[a] = a + 1;
            }

            // 승패 문자열을 2차원 배열에 표현
            for(int b = 0; b < weights.Length; b++)
            {
                for(int c = 0; c < weights.Length; c++)
                {
                    head[b,c] = head2head[b].Substring(c, 1);
                }
            }

            // 승률 계산
            for(int d = 0; d < weights.Length; d++) // 자신
            {
                for(int e = 0; e < weights.Length; e++) // 상대
                {
                    if(d != e)
                    {
                        if (head[d, e] == "N" && head[e, d] == "N")
                        {
                            count += 0;
                            round += 0;
                        }
                        else if (head[d, e] == "W" && head[e, d] == "L")
                        {
                            count++;
                            round++;
                        }
                        else if (head[d, e] == "L" && head[e, d] == "W")
                        {
                            round++;
                        }
                    }
                }
                pWinRate[d] = ((double)count / (double)round * 100);
                if (pWinRate[d].Equals(Double.NaN))
                {
                    pWinRate[d] = 0;
                }
                count = 0;
                round = 0;
            }

            // 자기보다 무거운 사람 이긴 횟수
            for(int f = 0; f < weights.Length; f++) // 기준
            {
                if (pWinRate[f] > 0)
                {
                    for (int g = 0; g < weights.Length; g++) // 상대
                    {
                        if (f != g)
                        {
                            if(head[f,g] == "W" && head [g,f] == "L")
                            {
                                if (weights[f] < weights[g])
                                {
                                    count++;
                                }
                            }
                        }
                    }
                    pHwin[f] = count;
                    count = 0;
                }
            }

            count = 1;
            for(int i = 0; i < weights.Length; i++)
            {
                for(int j = 0; j < weights.Length; j++)
                {
                    if (pWinRate[i] < pWinRate[j])
                    {
                        count++;
                    }
                    else if (pWinRate[i] == pWinRate[j])
                    {
                        if (pHwin[i] < pHwin[j])            
                        {
                            count++;
                        }
                        else if (pHwin[i] == pHwin[j])
                        {
                            if (weights[i] < weights[j])
                            {
                                count++;
                            }
                            else if (weights[i] == weights[j])
                            {
                                if (pNum[i] > pNum[j])
                                {
                                    count++;
                                }
                            }
                        }
                    }
                }
                result[i] = count;
                count = 1;
            }

            for(int k = 0; k < weights.Length; k++)
            {
                for(int l = 0; l < weights.Length; l++)
                {
                    if (result[l] == k+1)
                    {
                        answer[k] = pNum[l];
                        break;
                    }
                }
            }
            return answer;
        }
    }
}
// i+1번 선수의 승률이 j+1번 선수의 승률보다 작을 때
/*if (pWinRate[i] < pWinRate[j])
{
    count++;
}
// i+1번 선수의 승률이 j+1번 선수의 승률과 같을 때
else if (pWinRate[i] == pWinRate[j])
{
    // i+1번 선수의 횟수가 j+1번 선수의 횟수보다 작을 때
    if (pHwin[i] < pHwin[j])
    {
        count++;
    }
    // i+1번 선수의 횟수가 j+1번선수 횟수와 같을 때
    else if (pHwin[i] == pHwin[j])
    {
        // i+1번 선수의 몸무게가 j+1번 선수의 몸무게보다 작을 때
        if (weights[i] < weights[j])
        {
            count++;
        }
        // i+1번 선수의 몸무게가 j+1번 선수의 몸무게와 같을 때
        else if (weights[i] == weights[j])
        {
            // i+1번 선수의 번호가 j+1번 선수의 번호보다 작을 때
            if (pNum[i] < pNum[j])
            {

            }
            // i+1번 선수의 번호가 j+1번 선수의 번호보다 클 때
            else if (pNum[i] > pNum[j])
            {
                count++;
            }
        }
        // i+1번 선수의 몸무게가 j+1번 선수의 몸무게보다 클 때
        else if (weights[i] > weights[j])
        {

        }
    }
    // i+1번 선수의 횟수가 j+1번 선수의 횟수보다 클 때
    else if (pHwin[i] > pHwin[j])
    {

    }
}
// i+1번 선수의 승률이 j+1번 선수의 승률보다 클 때
else if (pWinRate[i] > pWinRate[j])
{

}*/
/*for (int h = 0; h < weights.Length; h++)
{
    Console.WriteLine("선수 번호: {0}", pNum[h]);
    Console.WriteLine("전적: {0}", head2head[h]);
    Console.WriteLine("승률: {0}", pWinRate[h]);
    Console.WriteLine("자신보다 무거운 선수 이긴 횟수: {0}", pHwin[h]);
    Console.WriteLine("선수 몸무게: {0}", weights[h]);
    Console.WriteLine("우선순위: {0}", result[h]);
    Console.WriteLine("====================================");
}*/