using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class DelegateExercises
    {
        public delegate void MyDelegate(int num);

        public static void Main(string[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method2();
        }

        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate(60);
        }
    }

   
}
