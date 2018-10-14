using System;

namespace Entrevista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write(GetMod(10, 21));
            Console.ReadKey();
        }
        public static int GetMod(int a, int b)
        {
            int count = 0;
            int result = 0;
            while (result < b)
            {
                result = a * count;
                count++;
            }
            result -= a;
            return b - result;
        }
    }
   
    //abstract class MiClase
    //{
    //    abstract public virtual void MiMetodo()
    //    { }
    //}
}
