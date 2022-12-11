using System;

namespace lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 4
            Se citeste de la tastatura un vector continant n numere intregi, n fiind si el citit la randul sau citit de la tastatura. Scrieti functii care vor returna
            • Cel mai mare numar din vector
            • Cel mai mic numar din vector
            • Numerele divizibile cu 3
             */

            Console.WriteLine("Intrduceti numarul de elemente pe care il va avea vectorul");
            int[] numbersArray = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < numbersArray.Length; i++) {
                Console.WriteLine($"Introduceti elementul numarul {i+1}");
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            static int MaxNumber(int[] Arr)
            {
                int max = Arr[0];
                for (int i = 1; i < Arr.Length; i++)
                {
                    if (Arr[i] > max)
                        max = Arr[i];
                }
                return max;
            }

            static int MinNumber(int[] Arr)
            {
                int min = Arr[0];
                for (int i = 1; i < Arr.Length; i++)
                {
                    if (Arr[i] < min)
                        min = Arr[i];
                }
                return min;
            }

            static void FilterCanDivideByThree(int[] Arr)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i] % 3 == 0)
                    {
                        Console.Write($"{Arr[i]} ");
                    }
                }
            }





            Console.WriteLine($"Cel mai mare numar din vector este {MaxNumber(numbersArray)}");
            Console.WriteLine($"Cel mai mic numar din vector este {MinNumber(numbersArray)}");
            Console.Write("Numerele divizibilie cu 3 din vector sunt: ");
            FilterCanDivideByThree(numbersArray);
        }
    }
}
