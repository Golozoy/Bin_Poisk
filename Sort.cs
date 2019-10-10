using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Бинарный_поиск
{
    class Sort
    {
        static public int[] sort1(int[] Arr)
        {
            List<int> CopiArr = new List<int>();
            foreach (int el in Arr)
                CopiArr.Add(el);
            CopiArr.Sort();
            CopiArr.CopyTo(Arr, 0);          
            return Arr;
        }

        static public int binPoisk(int target, int[] array)
        {
            int mid;
            int left = 0;
            int right = array.Length - 1;
            mid = (right + left) / 2;
            while (left < right - 1)
            {
                mid = (right + left) / 2;
                if (array[mid] == target)
                    return mid;
                if (array[mid] < target)
                    left = mid;
                else
                    right = mid;
            }
            if (array[mid] != target)
            {
                if (array[left] == target)
                    mid = left;
                else
                {
                    if (array[right] == target)
                        mid = right;
                    else
                        mid = -1;
                };
            }
            return mid;
        }
        static public void vivod(int[] arr)
        {
            foreach (int el in arr)
                Console.Write( $"{el} ");
        }
        static public int vvod(int a)
        {
            if (a != 7)
            {
                Random rnd = new Random();
                
                   int ass = rnd.Next(2, 20);
                return ass; 
            }
            
                Console.Write("Ведите положительное число элементов массива, используя цифры на клавеотере: \n ");
                int k = Convert.ToInt32(Console.ReadLine());
                return k;
            
            
        }
        static public int vibor()
        {
            Console.Write( "Если хотите задать размер массива-жмите на 7, в противном случии нажми на любую цифру и я решу за тебя ;) \n");
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
            
        }
    }
}

