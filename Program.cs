using System;

namespace Prime_or_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter valid number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int j = 2;

            if (num < 1)
            {
                Console.WriteLine("Opps! Something went wrong! Try again!");
                return;

            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (j < num)
                    {
                        j *= num;
                        //.....i skipped important part

                    }
                    else if (j == num)
                    {
                        Console.WriteLine("{0} is a Prime Number", num);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey(true);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("{0} is a composite", num);
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey(true);
                        return;

                    }




                }
            }

        }
    }
}


            
