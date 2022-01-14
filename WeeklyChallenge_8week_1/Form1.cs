using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeeklyChallenge_8week_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //int[,] cardOne = { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            //int[,] cardTwo = { { 10, 7 }, { 12, 3 }, { 8, 15 }, { 14, 7 }, { 5, 15 } };
            //int[,] cardThree = { { 14, 4 }, { 19, 6 }, { 6, 16 }, { 18, 7 }, { 7, 11 } };

            int[,] sizes = new int[,] { { 60, 50 }, { 30, 70 }, { 60, 30 }, { 80, 40 } };
            solution(sizes);
            Console.WriteLine();
        }

        public int solution(int[,] sizes)
        {
            // 가로 - hori, 세로 - vert
            int[,] card = sizes;

            int[] cardHori = new int[card.Length / 2];
            int[] cardVert = new int[card.Length / 2];
            int horiNum = 0;
            int vertNum = 0;
            int highHori = 0;
            int highvert = 0;

            for (int i = 0; i < card.Length / 2; i++)
            {
                cardHori[i] = card[i, 0];
                cardVert[i] = card[i, 1];
            }

            for (int j = 0; j < card.Length / 2; j++)
            {
                for (int l = 1; l < card.Length / 2; l++)
                {
                    if (cardHori[j] > cardHori[l])
                    {
                        horiNum = cardHori[j];
                        highHori = j;
                    }
                    else
                    {
                        horiNum = cardHori[l];
                        highHori = l;
                    }
                    if (cardVert[j] > cardVert[l])
                    {
                        vertNum = cardVert[j];
                        highvert = j;
                    }
                    else
                    {
                        vertNum = cardVert[l];
                        highvert = l;
                    }
                }
            }
            if(horiNum > vertNum)
            {

            }
            else
            {

            }

            int answer = 0;
            return answer;
        }
    }
}
