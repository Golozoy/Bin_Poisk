using System;

namespace Бинарный_поиск
{
    class Program
    {

        static void Main(string[] args)
        {
            
            
                int a = Sort.vibor();
                int col = Sort.vvod(a);
                int[] arr = new int[col];
                Random rnd = new Random();
                for (int i = 0; i < col; i++)
                {
                    arr[i] = rnd.Next(0, 100);
                }
                Console.WriteLine("Исходный массив:");
                Sort.vivod(arr);
                Sort.sort1(arr);
                Console.WriteLine("\nОтсортированный массив:");
                Sort.vivod(arr);
            do { 
                Console.Write("\n Ввести элемент поиска: ");
                int target = Convert.ToInt32(Console.ReadLine());
                int k = Sort.binPoisk(target, arr);
                Console.WriteLine("Бинарный поиск:");
                if (k > -1)
                    Console.WriteLine("Индек запрошеного элемента = {0}", k);
                else
                    Console.WriteLine("Данного элимента нет в массиве");
                //Console.WriteLine("Для выхода жмякни по клаве.");
                //Console.ReadKey();
                Console.WriteLine("Для выхода нажмите на q для повтора любой символ");

                
            }
            while (Console.ReadLine() != "q");
            
            
       }
    }
}
