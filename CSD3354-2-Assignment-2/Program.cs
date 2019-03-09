using System;

namespace DelegatesAndEvents
{
    class program
    {
        public static void Main(String[] args)
        {
            DelegateExercises delegatesExercises = new DelegateExercises();
            delegatesExercises.Method3();
            Console.ReadLine();

        }
    }
    public delegate void Mydelegate();
    public class DelegateExercises
    {

        void Method1()
        {
            Console.WriteLine("method1");
        }

        public void Method3()
        {
            Mydelegate myDelegate = new Mydelegate(Method1);
            myDelegate();
            Console.WriteLine(myDelegate.ToString());
        }
    }
}