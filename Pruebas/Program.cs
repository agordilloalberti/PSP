using System;

namespace Pruebas
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Action myAction;
            myAction = () => Console.WriteLine("Er delegao eh er mejoh");
            myAction.Invoke();
            Action x = (Action)myAction.GetInvocationList()[0];
            myAction -= x;
            myAction += () => Console.WriteLine("Er delegao eh er peoh");
            myAction.Invoke();
            
        }
    }
}