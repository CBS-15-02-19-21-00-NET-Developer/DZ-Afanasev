using System;
using System.Collections;
//using System.Collections;
using System.Collections.Generic;

namespace Collection
{
    class MyClass
    {
        public int MyIntProperty { get; set; }
        public string MyStringProperty { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(0.02);
            arrayList.Add("Hello");
            arrayList.Add('k');
            arrayList.Add(new MyClass());            

            for (int i = 0; i < arrayList.Count; i++) 
                //Console.WriteLine((object)arrayList[i]);
                Console.WriteLine(arrayList[i]);

            //да проблемы осбой нет, все выводится, только надо учитвыать, что все приведено к object         


        }
    }
}
