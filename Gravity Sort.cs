using System;
using System.Linq;

namespace Gravity_Sort {
    class Program {
        static void Main( string[] args ) {

            Console.WriteLine("Please enter the length of the array");
            int lengthArray = int.Parse(Console.ReadLine());

            int[] array1 = new int[lengthArray];

            Console.WriteLine("Please enter the maximum number to be generated");
            int maxnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the minimum number to be generated");
            int minnum = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInitial Array1 (Unsorted)");

            Random rnd = new Random();
            for ( int i = 0; i < array1.Length; i++ ) {
                array1[i] = rnd.Next(minnum, maxnum);
                Console.Write(array1[i] + " ");
            }

            Console.WriteLine("\n\nDeduction of Array1\n");

            int[] array2 = new int[array1.Max()];

            int tmp = 0;
            bool flag = false;
            int counter = 0;

            while ( flag != true ) {

                for ( int i = 0; i < array1.Length; i++ ) {

                    Console.Write(array1[i] + " ");

                    if ( array1[i] != 0 ) {
                        array1[i]--;
                        tmp++;
                    }
                }

                Console.WriteLine("\n");

                if ( tmp != 0 ) {
                    array2[counter] = tmp;
                } else {
                    flag = true;
                }
                tmp = 0;
                counter++;
            }

            Console.WriteLine("\nDeduction of Array2\n");

            flag = false;
            counter = 0;
            tmp = 0;

            while ( flag != true ) {

                for ( int i = 0; i < array2.Length; i++ ) {
                    Console.Write(array2[i] + " ");
                    if ( array2[i] != 0 ) {
                        array2[i]--;
                        tmp++;
                    }
                    
                }

                Console.WriteLine("\n");

                if ( tmp != 0 ) {
                    array1[counter] = tmp;
                } else {
                    flag = true;
                }
                tmp = 0;
                counter++;
            }

            Console.WriteLine("\nArray1 (Sorted)\n");

            for ( int i = 0; i < array1.Length; i++ ) {
                Console.Write(array1[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
