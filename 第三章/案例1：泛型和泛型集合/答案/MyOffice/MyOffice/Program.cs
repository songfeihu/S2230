using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyOffice
{
    class Program
    {
        static void Main(string[] args)
        {
           // ArrayList list1 = new ArrayList();


            SE se = new SE();
            se.ID = "111";
            se.Name = "张三";
            se.Age = 20;
            se.Gender = Gender.male;
            se.Popularity = 99;

            SE se2 = new SE();
            se2.ID = "112";
            se2.Name = "李四";
            se2.Age = 23;
            se2.Gender = Gender.male;
            se2.Popularity =29;

            PM pm = new PM();
            pm.Id = "007";
            pm.Name = "张经理";
            pm.Age = 35;

            Dictionary<string, SE> ses = new Dictionary<string, SE>();
            ses.Add(se.ID, se);//添加元素,有严格的类型检查,不需要装箱
            ses.Add(se2.ID, se2);//key不能重要.不能为空
            // ses.Add(pm.Id, pm);

            SE ss = ses["111"];//访问元素,通过key访问,不存在会报错
            Console.WriteLine(ss.SayHi());
            //ses.Remove("115");//删除元素,通过key删除,不存在该key不会报错
            Console.WriteLine(ses.Count);
            //循环keys
            foreach (string key in ses.Keys)
            {
                Console.WriteLine(key);
            }
            //循环values
            foreach (SE s in ses.Values)
            {
                Console.WriteLine(s.SayHi());
            }
            //循环键值对
            foreach (KeyValuePair<string,SE> item in ses)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.SayHi());
            }

            /*
            List<SE> listSe = new List<SE>();//泛型集合
            listSe.Add(se);//0 不需要装箱,有严格类型检查
            listSe.Add(se2);//1 0
            //listSe.Add(pm);
            //listSe.Add(19);
            //listSe.Add("qqq");

            foreach (SE obj in listSe)
            {
                Console.WriteLine(obj.SayHi());
            }
            Console.WriteLine("************************");
            for (int i = 0; i < listSe.Count; i++)
            {
                SE ss = listSe[i];
                Console.WriteLine(ss.SayHi());
            }

            listSe.Remove(se);//按对象删除
            listSe.RemoveAt(1);//按下标删除
            listSe.Clear();//清空所有数据
            */

            //List<int> listInt = new List<int>();
            //listInt.Add(19);
            //listInt.Add("fdsf");
            //listInt.Add(se);


            //list1.Add(se);
            //list1.Add(se2);
            //list1.Add(pm);
            //Console.WriteLine("个数为:"+list1.Count);

            //foreach (object obj in list1)
            //{
            //    SE ses = (SE)obj;//拆箱
            //    Console.WriteLine(ses.SayHi());
            //}

            Console.ReadLine();

        }
    }
}
