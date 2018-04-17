using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public static class XXX
    {
        public static void HelloWorld(this String a)
        {
            Console.WriteLine(a);
        }
        //public static int First(this int[] a)
        //{
        //    return a[0];
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "vova";
            //s.HelloWorld();
            int[] arr = new int[] { 8, 4, 7, 3, 1 };
            Console.WriteLine(arr.First());
        }
    }
}
