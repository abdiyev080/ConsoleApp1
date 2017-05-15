using System;

namespace ConsoleApp30
{
    class Hekim
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            string ad = "jack";
            string ad1 = Console.ReadLine();
             string[] shobe = { "Travmotologiya", "Nevrologiya", "Urologiya", };
             string[] travmotologiya = { "Ali", "Nadir" };
            string[] nevrologiya = { "Kamran", "Sadig" };
            string[] urologiya = { "Seymur", "Oktay" };
            if (ad == ad1)
            {
                Console.WriteLine("Shobeni Secin");
                for (int i = 0; i < shobe.Length; i++)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), shobe[i]);
                }
            }
            int sec = Convert.ToInt32(Console.ReadLine());

                   
            if (sec == 1)  
                {
                    Console.WriteLine("Hekim secimi");
                for (int i = 0; i < travmotologiya.Length; i++)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), travmotologiya[i]);
                }
                }
            if (sec == 2)
            {
                Console.WriteLine("Hekim secimi");
                for (int i = 0; i < nevrologiya.Length; i++)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), nevrologiya[i]);
                }
            }
            if (sec == 3)
            {
                Console.WriteLine("Hekim secimi");
                for (int i = 0; i < urologiya.Length; i++)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), urologiya[i]);
                }
            }
            string hekim = Console.ReadLine();
            if (hekim == travmotologiya[0])
            {
                for (int i = 0; i < travmotologiya.Length; i++)
                {
                    Console.WriteLine("{0}.{1}", (i + 1), travmotologiya[i]);

            }



        }

    }
    }


      
    
