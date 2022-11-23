using System;
using System.Reflection;


namespace Gihyo 
{
    class Program 
    {
        static void Main() 
        {
            SampleMethod();
        }

        static void SampleMethod() 
        {
            // 現在のメソッド名を得る得る
            var method = MethodBase.GetCurrentMethod();
            Console.WriteLine(method.Name);

            // 現在のクラスを得る得る
            string className = MethodBase.GetCurrentMethod()
                .DeclaringType.FullName;
            Console.WriteLine(className);
        }
    }
}