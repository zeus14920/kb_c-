using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codingTest2021_intern2_1
{
    class Pos
    {
        public int x;
        public int y;

        public Pos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[,] places = new string[,]
            {
                    { "PPXXX", "XXXXX", "XXXXX", "XXXXX", "XXXXX" },
                    { "POPOP", "XXXXX", "XXXXX", "XXXXX", "XXXXX" },
                    { "PXXXX", "OXXXX", "PXXXX", "OXXXX", "PXXXX" },
                    { "POXXX", "XPXXX", "XXXXX", "XXXXX", "XXXXX" },
                    { "PXXXX", "OPXXX", "XXXXX", "XXXXX", "XXXXX" }
            };

            int[] arr = solution(places);
            Console.WriteLine("결과값: " + solution(places));
            for (int i=0; i< arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }

        public int[] solution(string[,] places)
        {
            string[] arrPl = new string[5];
            string[,] arrStr = new string[5,5];
            List<Pos> loc = new List<Pos>();
            int[] answer = new int[5] {
                1, 1, 1, 1, 1
            };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arrPl[j] = places[i, j];
                    for (int k = 0; k < 5; k++)
                    {
                        string str = arrPl[j];
                        arrStr[j, k] = str.Substring(k, 1);
                    }
                }
                for(int l = 0; l < 5; l++)
                {
                    for(int m = 0; m < 5; m++)
                    {
                        if(arrStr[l, m] == "P")
                        {
                            /*Pos p = new Pos(l, m);
                            loc.Add(p);*/

                            loc.Add(new Pos(l, m));
                            //Console.WriteLine("P값 x좌표:{0}, y좌표:{1}", p.x, p.y);
                        }
                    }
                }
                for(int n = 0; n < loc.Count-1; n++)
                {
                    for(int o = n+1; o < loc.Count; o++)
                    {
                        int street = Math.Abs(loc[n].x - loc[o].x) + Math.Abs(loc[n].y - loc[o].y);
                        if (street <= 2)
                        {
                            if (loc[n].x == loc[o].x)
                            {
                                if(Math.Abs(loc[n].y - loc[o].y)<=2)
                                {
                                    if (arrStr[loc[o].x, (loc[o].y - 1)] == "O")
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                    else if(Math.Abs(loc[n].y - loc[o].y) == 1)
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                    else if (Math.Abs(loc[n].y - loc[o].y) == 0)
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                }
                            }
                            else if (loc[n].x < loc[o].x)
                            {
                                if(loc[n].y == loc[o].y)
                                {
                                    if (Math.Abs(loc[n].x - loc[o].x) == 2)
                                    {
                                        if (arrStr[(loc[o].x - 1), (loc[o].y)] == "O")
                                        {
                                            answer[i] = 0;
                                            break;
                                        }
                                    }
                                    else if (Math.Abs(loc[n].y - loc[o].y) == 1)
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                    else if (Math.Abs(loc[n].y - loc[o].y) == 0)
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                }

                                else if (loc[n].y < loc[o].y)
                                {
                                    if(arrStr[(loc[o].x-1),loc[o].y] == "O" || arrStr[loc[o].x, (loc[o].y - 1)] == "O")
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                }

                                else if (loc[n].y > loc[o].y)
                                {
                                    if(arrStr[(loc[o].x - 1), loc[o].y] == "O" || arrStr[loc[o].x, (loc[o].y + 1)] == "O")
                                    {
                                        answer[i] = 0;
                                        break;
                                    }
                                }
                            }
                        }                        
                    }
                }
                if(answer[i] != 0)
                {
                    answer[i] = 1;
                }
                loc.Clear();
            }
            return answer;
        }
    }
}

/*for(int l = 0; l < 5; l++)
                {
                    for(int m=0; m < 5; m++)
                    {

                    }
                }*/
/*int street = Math.Abs(loc[n].x - loc[n + 1].x) + Math.Abs(loc[n].y - loc[n + 1].y);
if (street <= 2)
{
    if (loc[n].x == loc[n + 1].x)
    {
        if (Math.Abs(loc[n].y - loc[n + 1].y) == 2)
        {
            if ((loc[n + 1].y - 1).ToString() == "O")
            {
                answer[i] = 0;
                break;
            }
        }
    }
    else if (loc[n].y == loc[n + 1].y)
    {
        if (Math.Abs(loc[n].x - loc[n + 1].x) == 2)
        {
            if ((loc[n + 1].x - 1).ToString() == "O")
            {
                answer[i] = 0;
                break;
            }
        }
    }
}*/