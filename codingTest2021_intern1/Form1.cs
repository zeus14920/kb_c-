using System;
using System.Windows.Forms;

namespace codingTest2021_intern1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string s = "one4seveneight";
            Console.WriteLine("결과값: " + solution(s));
        }

        int solution(string s)
        {
            string answer = "";

            if (s.Length >= 1 && s.Length <= 50)
            {
                string[] arrS = new string[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    arrS[i] = s.Substring(i, 1);
                }
                if (arrS[0] == "0" && s.Substring(0, 4) == "zero")
                {
                    Console.WriteLine("잘못된 입력 값입니다.");
                }
                for (int j = 0; j < s.Length; j++)
                {
                    switch (arrS[j])
                    {
                        case "0":
                            answer += "0";
                            break;
                        case "1":
                            answer += "1";
                            break;
                        case "2":
                            answer += "2";
                            break;
                        case "3":
                            answer += "3";
                            break;
                        case "4":
                            answer += "4";
                            break;
                        case "5":
                            answer += "5";
                            break;
                        case "6":
                            answer += "6";
                            break;
                        case "7":
                            answer += "7";
                            break;
                        case "8":
                            answer += "8";
                            break;
                        case "9":
                            answer += "9";
                            break;
                    }

                    if (j == s.Length - 1)
                    {
                        break;
                    }
                    else if (s.Substring(j, 2) == "ze")
                    {
                        answer += "0";
                        j += 3;
                    }
                    else if (s.Substring(j, 2) == "on")
                    {
                        answer += "1";
                        j += 2;
                    }
                    else if (s.Substring(j, 2) == "tw")
                    {
                        answer += "2";
                        j += 2;
                    }
                    else if (s.Substring(j, 2) == "th")
                    {
                        answer += "3";
                        j += 4;
                    }
                    else if (s.Substring(j, 2) == "fo")
                    {
                        answer += "4";
                        j += 3;
                    }
                    else if (s.Substring(j, 2) == "fi")
                    {
                        answer += "5";
                        j += 3;
                    }
                    else if (s.Substring(j, 2) == "si")
                    {
                        answer += "6";
                        j += 2;
                    }
                    else if (s.Substring(j, 2) == "se")
                    {
                        answer += "7";
                        j += 4;
                    }
                    else if (s.Substring(j, 2) == "ei")
                    {
                        answer += "8";
                        j += 4;
                    }
                    else if (s.Substring(j, 2) == "ni")
                    {
                        answer += "9";
                        j += 3;
                    }
                }
            }
            return Convert.ToInt32(answer);
        }
        
    }
}
/*
            for (int j = 0; j < s.Length; j++)
                {
                    switch (arrS[j])
                    {
                        case "0":
                            answer += 0;
                            break;
                        case "1":
                            answer += 1;
                            break;
                        case "2":
                            answer += 2;
                            break;
                        case "3":
                            answer += 3;
                            break;
                        case "4":
                            answer += 4;
                            break;
                        case "5":
                            answer += "5";
                            break;
                        case "6":
                            answer += "6";
                            break;
                        case "7":
                            answer += "7";
                            break;
                        case "8":
                            answer += "8";
                            break;
                        case "9":
                            answer += "9";
                            break;
                    }

                    if (j == s.Length-1)
                    {
                        break;
                    }
                    else if (s.Substring(j, 2) == "ze")
                    {
                        answer += "0";
                        j += 3;
                    }
                    else if(s.Substring(j, 2) == "on")
                    {
                        answer += "1";
                        j += 2;
                    }
                    else if (s.Substring(j, 2) == "tw")
                    {
                        answer += "2";
                        j += 2;
                    }
                    else if (s.Substring(j, 2) == "th")
                    {
                        answer += "3";
                        j += 4;
                    }
                    else if (s.Substring(j, 2) == "fo")
                    {
                        answer += "4";
                        j += 3;
                    }
                    else if (s.Substring(j, 2) == "fi")
                    {
                        answer += "5";
                        j += 3;
                    }
                    else if (s.Substring(j, 2) == "si")
                    {
                        answer += "6";
                        j += 2;
                    }
                    else if (s.Substring(j, 2) == "se")
                    {
                        answer += "7";
                        j += 4;
                    }
                    else if (s.Substring(j, 2) == "ei")
                    {
                        answer += "8";
                        j += 4;
                    }
                    else if (s.Substring(j, 2) == "ni")
                    {
                        answer += "9";
                        j += 3;
                    }
                }
                if (int.Parse(answer) > 2000000000 || int.Parse(answer) < 1)
                {
                    Console.WriteLine("1이상 2000000000이하의 값을 입력하세요");
                }
                else
                {
                    Console.WriteLine("{0}", answer);
                }
            }
        }
    }
}
*//*
 if (arrS[j] == "o" && arrS[k+1] == "n"&&arrS[k+2]=="e")
                        {
                            Console.Write(1+"");
                            break;
                        }
                        else if(arrS[j] == "t" && arrS[k+1] == "w" && arrS[k+2] == "o")
                        {
                            Console.Write(2 + "");
                            break;
                        }
                        else if (arrS[j] == "t" && arrS[k+3] == "e" && arrS[k + 4] == "e")
                        {
                            Console.Write(3 + "");
                            break;
                        }
                        else if (arrS[j] == "f" && arrS[k+2] == "u" && arrS[k + 3] == "r")
                        {
                            Console.Write(4 + "");
                            break;
                        }
                        else if (arrS[j] == "f" && arrS[k+2] == "v" && arrS[k + 3] == "e")
                        {
                            Console.Write(5 + "");
                            break;
                        }
                        else if (arrS[j] == "s" && arrS[k+1] == "i" && arrS[k + 2] == "x")
                        {
                            Console.Write(6 + "");
                            break;
                        }
                        else if (arrS[j] == "s" && arrS[k+3] == "e" && arrS[k + 4] == "n")
                        {
                            Console.Write(7 + "");
                            break;
                        }
                        else if (arrS[j] == "e" && arrS[k+3] == "h" && arrS[k + 4] == "t")
                        {
                            Console.Write(8 + "");
                            break;
                        }
                        else if (arrS[j] == "n" && arrS[k+2] == "n" && arrS[k + 1] == "e")
                        {
                            Console.Write(9 + "");
                            break;
                        }*/
/*
 * if(arrS[j] == "z" && arrS[k + 1] == "e")
                        {
                            answer += "0";
                            Console.Write(answer + "");
                            k += 3;
                            break;
                        }
                        else if (arrS[j] == "o" && arrS[k + 1] == "n")
                        {
                            answer += "1";
                            Console.Write(answer + "");
                            k += 2;
                            break;
                        }
                        else if (arrS[j] == "t" && arrS[k + 1] == "w")
                        {
                            answer += "2";
                            Console.Write(answer + "");
                            k += 2;
                            break;
                        }
                        else if (arrS[j] == "t" && arrS[k + 1] == "h")
                        {
                            answer += "3";
                            Console.Write(answer + "");
                            k += 4;
                            break;
                        }
                        else if (arrS[j] == "f" && arrS[k + 1] == "o")
                        {
                            answer += "4";
                            Console.Write(answer + "");
                            k += 3;
                            break;
                        }
                        else if (arrS[j] == "f" && arrS[k + 1] == "i")
                        {
                            answer += "5";
                            Console.Write(answer + "");
                            k += 3;
                            break;
                        }
                        else if (arrS[j] == "s" && arrS[k + 1] == "i")
                        {
                            answer += "6";
                            Console.Write(answer + "");
                            k += 2;
                            break;
                        }
                        else if (arrS[j] == "s" && arrS[k + 1] == "e")
                        {
                            answer += "7";
                            Console.Write(answer + "");
                            k += 4;
                            break;
                        }
                        else if (arrS[j] == "e" && arrS[k + 1] == "i")
                        {
                            answer += "8";
                            Console.Write(answer + "");
                            k += 4;
                            break;
                        }
                        else if (arrS[j] == "n" && arrS[k + 1] == "i")
                        {
                            answer += "9";
                            Console.Write(answer + "");
                            k += 3;
                            break;
                        }
 */