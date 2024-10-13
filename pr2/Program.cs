using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
                Console.Write("Введите длину массива:");
                int n = Convert.ToInt32(Console.ReadLine());

                int[] nums = new int[n];

                for (int i = 0; i < n; i++)
                {

                    nums[i] = i + 1;
                }

                Array.Reverse(nums);

                for (int i = 0; i < n; i++)
                {
                    Console.Write(nums[i]);
                    Console.Write(" ");
                }
            }
        }
    }
