using System;
using System.Collections;
using System.IO;

namespace Lesson6.collections.MyStack
{
    class L6Fourth
    {
        static void Main()
        {
            StreamReader filein = new StreamReader("D:\\data.txt");
            string text = filein.ReadToEnd();
            filein.Close();

            Stack stack = new Stack();
            bool check = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    stack.Push(i);
                }
                else if (text[i] == ')')
                {
                    if (stack.Count == 0)
                    {
                        check = false;
                        Console.WriteLine("В позиции {0} лишняя закрывающая скобка", i);
                    }

                    else
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Count == 0)
            {
                if (check)
                {
                    Console.WriteLine("Ошибок со скобками не выявлено! Все скобки сбалансированы!");
                }
                else
                {
                    Console.WriteLine("Возможно лишняя скобка");
                    while (stack.Count != 0)
                    {
                        Console.WriteLine($"{(int)stack.Pop()}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
