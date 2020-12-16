using System;
using System.Collections;

namespace Lesson6.First
{
    class Notorious
    {
        static void Main()
        {
            Queue notoriousQueue = new Queue();
            Random rndCabinet = new Random();
            for (int i = 1; ; i++)
            {
                Console.WriteLine("\nВведите ваше имя и фамилию, чтобы встать в очередь.");
                notoriousQueue.Enqueue(Console.ReadLine());
                if (notoriousQueue.Count == 6)
                {
                    Console.WriteLine($"\nУважаемый {notoriousQueue.Dequeue()}, пройдите в {rndCabinet.Next(1,10)} кабинет!");
                }
            }
        }
    }
}
