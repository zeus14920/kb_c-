using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingTest2021_intern2
{
    class Program
    {
        static void Main()
        {
            string[,] places= new string [,]
            { 
                { "POOOP", "OXXOX", "OPXPX", "OOXOX", "POXXP" }, // 1
                { "POOPX", "OXPXP", "PXXXO", "OXXXO", "OOOPP" }, // 0
                { "PXOPX", "OXOXP", "OXPOX", "OXXOP", "PXPOX" }, // 1
                { "OOOXX", "XOOOX", "OOOXX", "OXOOX", "OOOOO" }, // 1
                { "PXPXP", "XPXPX", "PXPXP", "XPXPX", "PXPXP" }  // 1
            };
        }
        public int[] solution(string[,] places)
        {
            string[] arrPl = new string[places.Length];
            for (int i = 0; i < places.Length; i++)
            {
                for (int j = 0; j < places.Length; j++)
                {
                    arrPl[j] = places[i, j];
                    Console.WriteLine(arrPl[j]);
                }
            }

            int[] answer = new int[] { };
            return answer;
        }
    }
}
