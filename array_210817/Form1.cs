using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace array_210817
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int num=5;
            do
            {
                Console.Write("1~16 범위 내의 숫자 입력: ");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0 || num > 16);

            Console.WriteLine("입력한 숫자: {0}", num);

            int aa = 01101; // 0x0D; // 01101;
            int bb = 10010; // 0x12; // 10010;
            int cc = aa | bb;
            Console.WriteLine("cc: {0}", cc);

            int[] arr1 = new int[num];
            int[] arr2 = new int[num];
            //int[] arr1 = { 9, 20, 28, 18, 11 };
            //int[] arr2 = { 30-,1,21,17,28 };
            string[] arr3 = new string[num];
            string[] arr4 = new string[num];
            //string[] arr5 = new string[num];
            int[] arr5 = new int[num];
            int[] arr6 = new int[num];
            int[] arr7 = new int[num];
            Random r = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                int arrNum1 = r.Next(0, (int)Math.Pow(2, num));
                arr1[i] = arrNum1;
                int arrNum2 = r.Next(0, (int)Math.Pow(2, num));
                arr2[i] = arrNum2;
                Console.WriteLine(" " + arr1[i]);
                Console.WriteLine(" " + arr2[i]);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = System.Convert.ToString(arr1[i], 2);
                arr4[i] = System.Convert.ToString(arr2[i], 2);
                arr5[i] = int.Parse(arr3[i]);
                arr6[i] = int.Parse(arr4[i]);

                Console.WriteLine(" " + arr1[i]);
                Console.WriteLine(" " + arr5[i]);
                Console.WriteLine(" " + arr2[i]);
                Console.WriteLine(" " + arr6[i]);

                arr7[i] = arr5[i] | arr6[i];

                Console.WriteLine(" " + arr7[i]);
                Console.WriteLine("====================");
            }


            int[] binary1 = new int[num];
            int[] binary2 = new int[num];
            int[] binary3 = new int[num];
            string[] output = new string[num];

            for (int i = 0; i < arr1.Length; i++)
            {
                binary1 = new int[num];
                binary2 = new int[num];
                binary3 = new int[num];
                for (int j = 0; j < num; j++)
                {
                    if (arr1[i] != 1)
                    {
                        binary1[j] = arr1[i] % 2;
                        arr1[i] = arr1[i] / 2;
                    }
                    else if (arr1[i] == 1)
                    {
                        binary1[j] = 1;
                        break;
                    }
                    else if (arr1[i] == 0)
                    {
                        break;
                    }
                }
                for (int j = 0; j < num; j++)
                {
                    if (arr2[i] != 1)
                    {
                        binary2[j] = arr2[i] % 2;
                        arr2[i] = arr2[i] / 2;
                    }
                    else if (arr2[i] == 1)
                    {
                        binary2[j] = 1;
                        break;
                    }
                    else if (arr2[i] == 0)
                    {
                        break;
                    }
                }

                for(int j = arr1.Length-1; j >=0; j--)
                {
                    binary3[i] = binary1[j] | binary2[j];

                    if (binary3[i] == 0)
                    {
                        output[i] += " ";
                    }
                    else if (binary3[i] == 1)
                    {
                        output[i] += "#";
                    }
                }
                Console.Write("{0},", output[i]);
                
            }
        }
    }
}
