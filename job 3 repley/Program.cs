using System;


namespace job_3_repley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Средний уровень 3 работы
            try
            {
                 int a = 3;
                 int b = 5;
                Random rnd = new Random();
                Console.WriteLine("случайные числа:");
                 int A = rnd.Next(10, 100);
                Console.WriteLine(A);
                 int B = rnd.Next(10, 100);
                Console.WriteLine(B);
                 int C = rnd.Next(10, 100);
                Console.WriteLine(C);
                 int D = rnd.Next(10, 100);
                Console.WriteLine(D);
                Console.WriteLine("--------------------------------------------------");
                 if (Convert.ToInt32(A) % a == 0)
                    Console.Write(A + " ");
                 if (Convert.ToInt32(B) % a == 0)
                    Console.Write(B + " ");
                 if (Convert.ToInt32(C) % a == 0)
                    Console.Write(C + " ");
                 if (Convert.ToInt32(D) % a == 0)
                    Console.Write(D + " ");
                Console.WriteLine(" - числа кратное (3)");
                 if (Convert.ToInt32(A) % b == 0)
                    Console.Write(A + " ");
                 if (Convert.ToInt32(B) % b == 0)
                    Console.Write(B + " ");
                 if (Convert.ToInt32(C) % b == 0)
                    Console.Write(C + " ");
                 if (Convert.ToInt32(D) % b == 0)
                    Console.Write(D + " ");
                Console.WriteLine(" - числа кратное (5)");
            }
            catch (Exception e)
            {
            Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
