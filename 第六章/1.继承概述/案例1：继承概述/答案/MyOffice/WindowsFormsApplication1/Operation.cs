using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{   

    /// <summary>
    /// 父类
    /// </summary>
   public  class Operation 
    {
       public double NumberA { get; set; }
       public double NumberB { get; set; }
       public virtual double GetResult() 
       {
           double result = 0;
           return result;
       }
    }
    //加法
   public class OperationAdd : Operation 
   {
       public override double GetResult()
       {
           double result = NumberA + NumberB;
           return result;
       }
   }
    //减法
   public class Operationjianfa : Operation
   {
       public override double GetResult()
       {
           double result = NumberA - NumberB;
           return result;
       }
   }
    //乘法
   public class Operationchengfa : Operation
   {
       public override double GetResult()
       {
           double result = NumberA * NumberB;
           return result;
       }
   }
    //除法
   public class OperationDiv : Operation
   {
       public override double GetResult()
       {
           if (NumberB==0)
           {
               throw new Exception("除数不能为0！！！");
           }
           double result = NumberA / NumberB;
           return result;
       }
   }
}
