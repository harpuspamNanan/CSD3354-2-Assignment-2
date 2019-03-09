using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvents
{
    public class DelegateExercises
    {
        public static void Main(String[] args)
        {
            DelegateExercises de = new DelegateExercises();
            de.Method2();
        }

        public delegate void MyDelegate();
        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }
        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
        }

       
    }
}



