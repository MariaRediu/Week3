using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ora1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dictionary<char, int> sir = new Dictionary<char, int>();
             sir.Add('a', 3);
             sir.Add('b', 2);
             sir.Add('c', 1);
             if (!sir.Keys.Contains('a'))
             {

             }*/


            //NthFibonacci();
            //AmstrongNumber();
            //PrimeNumber();
            //Duplicate();
            // Palindrom();
            // SelectionSort();
            //BubbleSort();


            // MajorityNumber();
            //SumOfDigits();
            //Duplicate();
            //int fact = Factorial(4);
            //Console.WriteLine(fact);
            //Console.ReadLine();
            //FindSum(5);
            // Suma();

        }

        private static void NthFibonacci()
        {
            int x = 0, y = 1, z = 0, nth, i;
            Console.WriteLine("\n\nIntrodu numar:");
            nth = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= nth; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }


            Console.WriteLine(" al  {0} -lea termen din seria Fibonacci este  {1}\n\n\n", nth, z);
            Console.ReadLine();
        }

        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //To return the primul Fibonacci number   
            if (n == 1) return 1; //To return the al doilea  Fibonacci number   
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
        private static void AmstrongNumber()
        {
            int numar, r, suma = 0, aux;
            Console.Write("Introduceti numarul: ");
            numar = int.Parse(Console.ReadLine());
            aux = numar;
            while (numar > 0)
            {
                r = numar % 10;
                suma = suma + (r * r * r);
                numar = numar / 10;
            }
            if (aux == suma)
            {
                Console.Write("Numar Armstrong.");
                Console.ReadLine();
            }

            else
            {
                Console.Write("Numarul nu este numar Armstrong.");
                Console.ReadLine();
            }
        }


        

        private static void PrimeNumber()
        {
            int numar = 0;
            Console.WriteLine("introduceti numarul:");
            numar = int.Parse(Console.ReadLine());
            if (numar == 0 || numar == 1)
            {
                Console.WriteLine(numar + " nu este prim");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i < numar / 2; i++)
                {
                    if (numar % i == 0)
                    {
                        Console.WriteLine(numar + " nu este prim");
                        Console.ReadLine();
                        return;
                    }
                }
                Console.WriteLine(numar + " este prim");
                Console.ReadLine();
            }
        }

        private static void Palindrom()
        {
            bool valoare;

            Console.Write(" Introdu un sir : ");
            string sir1 = Console.ReadLine();
            valoare = IsPalindrome(sir1);
            if (valoare == true)
            {
                Console.WriteLine(" Sirul este Palindrom.\n");
            }
            else
            {
                Console.WriteLine(" Sirul nu este  Palindrom.\n");
            }
            Console.ReadLine();
        }

        public static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }


        }
        private static void SelectionSort()
        {
            int[] sir = new int[] { 13, 24, 10, 45, 27, 83, 21 };
            int minim = 0;
            int aux;
            Console.WriteLine("sirul nesortat este:");
            for (int i = 0; i < sir.Length; i++)
            {
                Console.WriteLine(sir[i]);
            }

            for (int i = 0; i < sir.Length - 1; i++)
            {
                minim = i;
                for (int index = i + 1; index < sir.Length; index++)
                {
                    if (sir[index] < sir[minim])
                    {
                        minim = index;
                    }
                }
                aux = sir[minim];
                sir[minim] = sir[i];
                sir[i] = aux;
            }

            Console.WriteLine("sirul sortat este:");
            foreach (var item in sir)
            {
                Console.WriteLine(item + " ");
                Console.ReadLine();
            }
        }

        private static void BubbleSort()
        {
            int[] sir = new int[] { 20, 40, 50, 30, 10 };
            int aux;
            Console.WriteLine("Sirul este:");
            for (int i = 0; i < sir.Length; i++)
            {
                Console.WriteLine(sir[i]);
            }
            for (int j = 0; j < sir.Length - 2; j++)
            {
                for (int i = 0; i < sir.Length - 2; i++)
                {
                    if (sir[i] > sir[i + 1])
                    {
                        aux = sir[i + 1];
                        sir[i + 1] = sir[i];
                        sir[i] = aux;
                    }
                }
            }
            Console.WriteLine("Sirul sortat este:");
            foreach (int array in sir)
            {
                Console.Write(array + " ");
                Console.ReadLine();
            }
        }

        private static void MajorityNumber()
        {
            int[] sir = new int[] { 1, 3, 2, 4, 7, 8, 7, 7, 7 };
            int contor = 1;
            int numar = 0;
         

            for (int i = 0; i <= sir.Length; i++)
            {
                for (int j = i+1; j < sir.Length; j++)
                {
                    if (sir[i] == sir[j])
                    {
                        contor++;
                    }
                }
                if (contor > sir.Length / 2)
                {                 
                    numar = sir[i];             
                }
                contor = 0;
            }
            Console.WriteLine("Numarul " + numar);
            Console.ReadLine();
        }

        private static void SumOfDigits()
        {
            int nr = 43, x;
            int suma = 0;

            while (nr != 0)
            {
                x = nr % 10;
                suma = suma + x;
                nr = nr / 10;
            }
            Console.WriteLine(suma);
            Console.ReadLine();
        }

        private static void Duplicate()
        {
            int[] array = new int[] { 1, 2, 2, 4, 5, 6, 7, 8 };
            int find = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i +1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("Sirul contine duplicate");
                        find = 1;
                        break;
                    }
                    else
                        continue;
                }
                if (find == 1)
                    break;
                else
                    continue;
            }
            if (find == 0)
                Console.WriteLine("Sirul nu contine duplicate");
            Console.ReadLine();
        }


        public static int FactorialRecursiv(int nr)
        {
            if (nr == 1)
            {
                return 1;
            }

            return nr * FactorialRecursiv(nr - 1);

        }
        public static int Factorial(int nr)
        {
            int fact = 1;
            
            for (int i = nr; i >0; i--)
            {
                fact = fact * i;
            }
            
            return fact;
        }
        private static void FindSum(int sum)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {

                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine($"{arr[i]}+{arr[j]}={sum}");
                    }

                }
            }
        }
        private static void Suma()
        {
            int[] arr = new int[] { 2, 4, 5, 6 };

            int suma = 0;
            foreach (var nr in arr)
            {
                if (nr % 2 == 0)
                {
                    suma += nr;
                }
            }
            Console.WriteLine(suma);
            Console.ReadLine();
        }
    }
}
