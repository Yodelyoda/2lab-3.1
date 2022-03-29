using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_3._1_v3
{
    class Program
    {
       static void Main(string[] args)
        {
            string str;
            Console.Write($"Enter string:");
            str = Console.ReadLine();
            Console.Write($"String contained ", Count(str), "groups of 'n o':");
            string dest;
            dest = Change(str);
            Console.Write($"Modified string (param) : ", str);
            Console.Write($"Modified string (result): ", dest);
            string dest2;
            dest2 = Change2(str);
            Console.Write($"String after replacing: ", str);
            Console.ReadKey();

        }
        static int Count(string s)
        {
            int k = 0;
            int pos = 0;
            while ((pos = s.IndexOf('n', pos)) != -1)
            {
                pos++;
                if (s[pos + 1] == 'o')
                    k++;
            }
            return k;
        }
        static private string Change(string s)
        {
            int pos = 0;
            while ((pos = s.IndexOf('n', pos)) != -1)
                if (s[pos + 2] == 'o')
                    s.Replace("o", "**");
            return s;
        }
        static private string Change2(string s)
        {
            for (int i = 0; s[i] != ' '; i++)
            {
                if (Char.IsUpper(s,i))
                    s[i] = Char.ToUpper(s[i]);
            }
            return s;
        }
    }
}
