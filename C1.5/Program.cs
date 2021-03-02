using System;

namespace C1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int zi;
            Console.Write("Dati ziua:");
                try
            {
                zi = int.Parse(Console.ReadLine());
                switch (zi)
                {

                    case 1: Console.WriteLine("Luni"); break;
                    case 2: Console.WriteLine("Marti"); break;
                    case 3: Console.WriteLine("Miercuri");break;
                    case 4: Console.WriteLine("Joi");break;
                    case 5: Console.WriteLine("Vineri"); break;
                    case 6: Console.WriteLine("Sambata"); break;
                    case 7: Console.WriteLine("Duminica"); break;
                    default: Console.WriteLine("Zi eronata"); break;
                }
                Console.ReadLine();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);           
            }
        }
    }
}
