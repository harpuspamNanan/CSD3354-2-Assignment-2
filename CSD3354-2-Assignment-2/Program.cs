using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }
    }

    public class DelegateExercises
    {
        public delegate int MyDelegate();      
         public int Method1()
        {
            Console.WriteLine("MyDelegate");
            return 1;
        }

        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);           
            myDelegate();         
            Console.ReadLine();
        }
    }
   
}
