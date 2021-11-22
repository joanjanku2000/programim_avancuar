using System;

namespace ConsoleApp_Seminar1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input a number:");
            int number = 0;
            int[] array = new int[number];
            number = getNumber();
                if (number < 5)
                {
                array = new int[number];
                Console.WriteLine("Jep vlerat e arrayt");
                    for (int i = 0; i < number; i++)
                    {
                        array[i] = getNumber();
                    }
                } else
            {
                Console.WriteLine("Nuk ka memorie per vektor me madhesi > 5");
            }
     
            Console.WriteLine("Yous said " + name);
            Console.WriteLine("Array i dhene eshte {0}", toStringArray(array));
           
        }
        static string toStringArray(int[] array)
        {
            string arr = "[";
            for (int i = 0; i < array.Length; i++)
            {
                arr += " " + array[i];
            }
            arr += "]";
            return arr;
        }
        static int getNumber()
        {
            try
            {
                return Int32.Parse(Console.ReadLine());
            } catch (FormatException f)
            {
                throw new FormatException("Please enter a number")
;            }
        }
    }
}
