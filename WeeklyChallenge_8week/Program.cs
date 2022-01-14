using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyChallenge_8week
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] cardOne = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            //int[,] cardTwo = { { 10, 7 }, { 12, 3 }, { 8, 15 }, { 14, 7 }, { 5, 15 } };
            //int[,] cardThree = { { 14, 4 }, { 19, 6 }, { 6, 16 }, { 18, 7 }, { 7, 11 } };

            int[,] sizes = new int[,] { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            Solution solu = new Solution();
            solu.solution(sizes);
            Console.WriteLine(solu.solution(sizes));
            
        }
    }

    public class Solution
    {
        public int solution(int[,] sizes)
        {
            // 가로 - hori, 세로 - vert
            int[,] card = sizes;
            int[,] cardMin = new int[1, 2];
            int hori = card.GetLength(0);

            int[] cardHori = new int[hori];
            int[] cardVert = new int[hori];
            int horiNum = 0;
            int vertNum = 0;
            int horiNumArr = 0;
            int vertNumArr = 0;
            int mixNum = 0;
            int answer = 0;

            for (int i = 0; i < hori; i++)
            {
                cardHori[i] = card[i, 0];
                cardVert[i] = card[i, 1];
            }

            for(int j = 0; j < hori; j++)
            {
                horiNum = cardHori[j];
                horiNumArr = j;
                vertNum = cardVert[j];
                vertNumArr = j;
                for (int l = 1; l < hori; l++)
                {
                    if (horiNum <= cardHori[l])
                    {
                        horiNum = cardHori[l];
                        horiNumArr = l;
                    }
                    if (vertNum <= cardVert[l])
                    {
                        vertNum = cardVert[l];
                        vertNumArr = l;
                    }
                }
                break;
            }

            if (horiNum > vertNum)
            {
                mixNum = horiNum;
                cardMin[0, 0] = mixNum;
                cardMin[0, 1] = card[horiNumArr, 1];
            }
            else
            {
                mixNum = vertNum;
                cardMin[0, 0] = mixNum;
                cardMin[0, 1] = card[vertNumArr, 0];
            }
            
            for(int m = 0;m< hori; m++)
            {
                if(cardMin[0, 0] >= card[m, 0] && cardMin[0, 1] < card[m, 1])
                {
                    if(cardMin[0, 0] >= card[m, 1] && cardMin[0, 1] < card[m, 0])
                    {
                        if (card[m, 0] > card[m, 1])
                        {
                            cardMin[0, 1] = card[m, 1];
                        }
                        else
                        {
                            cardMin[0, 1] = card[m, 0];
                        }
                    }
                    else if(cardMin[0, 0] >= card[m, 1] && cardMin[0, 1] > card[m, 0])
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }

            return answer = cardMin[0, 0] * cardMin[0, 1];
        }
    }
}
