using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyChallenge_10week211013
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            int[,] line = { { 2, -1, 4 }, { -2, -1, 4 }, { 0, -1, 1 }, { 5, -8, -12 }, { 5, 8, 12 } };
            /*int[,] line = { { 0, 1, -1 }, { 1, 0, -1 }, { 1, 0, 1 } };
            int[,] line = { { 1, -1, 0 }, { 2, -1, 0 } };
            int[,] line = { { 1, -1, 0 }, { 2, -1, 0 }, { 4, -1, 0 } };*/
            solu.solution(line);
        }
        public class Solution
        {
            public string[] solution(int[,] line)
            {
                List<int[,]> coor = new List<int[,]>();
                int[] xNum = new int[line.GetLength(0)];
                int[] yNum = new int[line.GetLength(0)];
                int[] iNum = new int[line.GetLength(0)];
                for (int i = 0; i < line.GetLength(0); i++)
                {
                    xNum[i] = line[i, 0];
                    yNum[i] = line[i, 1];
                    iNum[i] = line[i, 2];
                }

                for (int j = 0; j < line.GetLength(0); j++)
                {
                    for (int k = j + 1; k < line.GetLength(0); k++)
                    {
                        coor.Add(meet(xNum[j],yNum[j],iNum[j],xNum[k],yNum[k],iNum[k]));
                    }
                }
                string[] answer = new string[] { };
                return answer;
            }

            public int[,] meet(int a, int b, int c, int d, int e, int f)
            {
                int x = 0;
                int y = 0;

                if (((a * d) - (b * c)) != 0)
                {
                    x = ((b * f) - (e * d)) / ((a * d) - (b * c));
                    y = ((e * c) - (a * f)) / ((a * d) - (b * c));
                }
                else if (((a * d) - (b * c)) != 0)
                {
                    x = 0;
                    y = 0;
                }
                int[,] arr = { { x, y } };
                return arr;
            }
        }        
    }
}
