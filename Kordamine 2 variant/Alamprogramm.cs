using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine_2_variant
{
    class Alamprogramm
    {
        public static void text()
        {
            Console.WriteLine("Insert the text");
            string text = Console.ReadLine();

            int count = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            Console.WriteLine("Words: " + count);

            Console.WriteLine("Spaces: "+ text.Where(x => x == ' ').Count());
        }

        public static void masNumbers()
        {
            Random rnd = new Random();
            int[] mas = new int[5];

            for (int i = 0; i < 5; i++)
            {
                mas[i] = rnd.Next(1, 10);
                Console.Write(mas[i] + "\t");
            }
            Console.WriteLine();

            int[] evenMas;
            int[] oddMas;
            var List1 = new List<int>();
            var List2 = new List<int>();
            int N = mas.Length;

            foreach (var item in mas)
            {
                if (item % 2 == 0)
                {
                    List1.Add(item);
                }
                else
                {
                    List2.Add(item);
                }
            }

            evenMas = List1.ToArray();
            oddMas = List2.ToArray();

            int n = evenMas.Length;
            int k = oddMas.Length;

            foreach (var item in evenMas)
            {
                int temp;
                int s = 1;
                for (int j = 0; j < mas.Length; j++)
                    for (int i = 0; i < mas.Length - 1; i++)
                    {

                        if (mas[i] * s > mas[i + 1] * s)
                        {
                            temp = mas[i];
                            mas[i] = mas[i + 1];
                            mas[i + 1] = temp;
                        }
                    }
                    Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in oddMas)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void lucyNum()
        {
            Console.WriteLine("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] mas = new int[num];
        }
    }
}
