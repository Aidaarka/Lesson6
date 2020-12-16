using System;
using System.Collections;

namespace Lesson6.First
{
    class Notary
    {
        static void Main()
        {
            Queue notaryQueue = new Queue();
            Random rndCabinet = new Random();
            for (int i = 1; ; i++)
            {
                Console.WriteLine("\nВведите ваше имя и фамилию, чтобы встать в очередь.");
                notaryQueue.Enqueue(Console.ReadLine());
                if (notaryQueue.Count == 6)
                {
                    Console.WriteLine($"\nУважаемый {notaryQueue.Dequeue()}, пройдите в {rndCabinet.Next(1,10)} кабинет!");
                }
            }
        }
    }
}
