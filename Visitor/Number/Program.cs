using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 7, 8, 3, 2, 5 };
            ConsoleKey key;
            int cur = num.Length - 1;
            int pos = num.Length - 1;       
            do
            {
                foreach (var item in num)
                    Console.Write(item);
                Console.CursorLeft = pos;
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        if (cur == 0)
                            cur = pos = num.Length;
                        cur--;
                        pos--;
                        break;
                    case ConsoleKey.RightArrow:
                        cur++;
                        pos++;
                        if (cur == num.Length)
                            cur = pos = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        num[cur]++;
                        if (num[cur] == 10)
                            num[cur] = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        num[cur]--;
                        if (num[cur] == -1)
                            num[cur] = 9;
                        break;
                }
                Console.Clear();
            } while(key != ConsoleKey.Escape);
          
        }
    }
}
