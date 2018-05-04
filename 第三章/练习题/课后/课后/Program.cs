using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 课后5
{
    class Program
    {
      public static List<Object> list = new List<Object>();
        public static void EnOueue(Object obj)
        {
            list.Add(obj);
        }
        public static Object DeQueue()
        {
            list.RemoveAt(0);
            return null;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入一个数:");
                int i = Int32.Parse(Console.ReadLine());
                Console.WriteLine("***********************");
                EnOueue(i);
                if(list.Count==6)
                {
                    DeQueue();
                }
                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
