using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asfsdaga
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solu = new Solution();
            //string[] p = { "11", "111", "11", "211" };
            string[] p = { "21", "123", "111", "11" };
            solu.solution(p);
            
        }
    }
    public class Solution
    {
        public string[] solution(string[] p)
        {
            string[] answer = new string[] { };
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            for (int j = 0; j < p.Length; j++)
            {
                a.Add(p[j]);
            }

            for (int i = 1; i < a.Count; i++)
            {
                
                string a0 = a[0];
                string a1 = a[i];

                string add1 = a0 + a1;
                string add2 = a1 + a0;

                for(int l =0; l < a1.Length; l++)
                {
                    char[] reverse1;
                    char[] reverse2;
                    reverse1[l] = Convert.ToChar(add1.Substring(l, l + 1));
                    reverse2[l] = Convert.ToChar(add2.Substring(l, l + 1));
                }

                //string ans1 = new string(reverse1);
                //string ans2 = new string(reverse2);

                if (add1 == ans1)
                {
                    b.Add(a1);
                    a.RemoveAt(0);
                    a.RemoveAt(0);
                    i--;                    
                }
                else if(add2 == ans2)
                {
                    b.Add(a1);
                    a.RemoveAt(0);
                    a.RemoveAt(0);
                    i--;
                }
            }
            for(int k = 0; k < b.Count; k++)
            {
                answer[k] = b[k];
            }            
            return answer;
        }
    }
}
