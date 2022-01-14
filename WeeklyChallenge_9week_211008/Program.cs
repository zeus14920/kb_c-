using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyChallenge_9week_211008
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            int[,] wires = { { 1, 3 }, { 2, 3 }, { 3, 4 }, { 4, 5 }, { 4, 6 }, { 4, 7 }, { 7, 8 }, { 7, 9 } };

            /*int n = 4;
            int[,] wires = { { 1, 2 },{ 2, 3 },{ 3, 4 } };*/

            /*int n = 7;
            int[,] wires = { { 1, 2 },{ 2, 7 },{ 3, 7 },{ 3, 4 },{ 4, 5 },{ 6, 7 } };*/

            Solution solu = new Solution();
            int answer = solu.solution(n, wires);
        }
    }

    public class Solution
    {
        public int solution(int n, int[,] wires)
        {
            List<int> wiresNum = new List<int>();
            List<int> countNum = new List<int>();
            int count = 0;
            int answer = 0;
            for (int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    wiresNum.Add(wires[i, j]);
                }
            }

            for(int k = 0; k < n; k++)
            {
                for (int l = 0; l < wires.Length; l++)
                {
                    if (wiresNum[l] == k + 1)
                    {
                        count++;
                    }
                }
                countNum.Add(count);
                count = 0;
            }

            for(int a =0; a < n; a++)
            {
                if (countNum[a] >= 3)
                {
                    answer++; 
                }
            }
            return answer;
        }
    }
}
