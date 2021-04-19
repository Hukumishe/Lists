using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First
            Console.WriteLine("<-- ПЕРВОЕ -->");
            Random rnd = new Random();
            List<int> list = new List<int>();
            int cnt = 0;
            int secondBig = 0;
            int position = 0;
            int sumEven = 0;

            for (int i = 0; i < rnd.Next(1, 5); i++)
            {
                int num = rnd.Next(1, 1000);
                if (i % 2 == 0)
                    sumEven += num;
                if (num > cnt)
                    cnt = num;
                if (num > secondBig && num < cnt)
                {
                    secondBig = num;
                    position = i;
                }

                list.Add(num);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Второй самый большой элемент: {0}\t Его позиция: {1}", secondBig, position);
            Console.WriteLine("Кол-во элементов: {0}\tСумма всех четных элементов: {1}", list.Count, sumEven);
            #endregion

            #region Second

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("<-- ВТОРОЕ -->");
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0 || i == 0)
                    list.Remove(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Кол-во элементов: {0}", list.Count);
            #endregion

            #region Third
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("<-- ТРЕТЬЕ -->");
            List<double> vs = new List<double>();

            for (int i = 0; i < rnd.Next(1, 5); i++)
            {
                double num = rnd.NextDouble();
                vs.Add(num);
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------------------");
            double average = 0;
            foreach (var item in vs)
            {
                average += item;
            }

            average /= vs.Count;

            foreach (var item in vs)
            {
                if (item > average)
                    Console.WriteLine(item);
            }
            #endregion

            #region Fourth
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("<-- ЧЕТВЕРТОЕ -->");
            StreamReader sr = new StreamReader("input.txt");
            string line = sr.ReadToEnd();

            Console.WriteLine(line.Reverse());
            #endregion

            #region Fifth
            string s1 = "asdfghj";
            string s2 = "jhgfdsa";

            if (s1.Length != s2.Length)
            {
                Console.WriteLine("Строки не обратны друг другу");
                return;
            }

            bool flag = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[s2.Length - i - 1])
                {
                    flag = false;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("Строки являются обратными друг другу.");
            #endregion

            #region Sixth

            #endregion

            #region Seventh
            Queue<int> positive = new Queue<int>();
            Queue<int> negative = new Queue<int>();

            StreamReader sr2 = new StreamReader("numbers.txt");

            string[] numbers = sr2.ReadToEnd().Split(new char[] { ' ', '.', ',', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numbers.Length; i++)
            {
                int result = 0;
                if (int.TryParse(numbers[i], out result))
                {
                    if (result > 0)
                        positive.Enqueue(result);
                    if (result < 0)
                        negative.Enqueue(result);
                }
            }

            Console.Write("Положительные числа: ");
            foreach (int num in positive)
            {
                Console.Write("{0} ", num);
            }

            Console.Write("\nОтрицательные числа: ");

            foreach (int num in negative)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            #endregion

            #region Nineth
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("<-- ДЕВЯТНОЕ -->");
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 != 0 || i == 0)
                    list.Remove(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Кол-во элементов: {0}", list.Count);
            #endregion

            #region Tenth
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("<-- ДЕСЯТНОЕ -->");
            List<double> vs1 = new List<double>();

            for (int i = 0; i < rnd.Next(1, 5); i++)
            {
                double num = rnd.NextDouble();
                vs.Add(num);
                Console.WriteLine(num);
            }
            Console.WriteLine("---------------------------------------");
            double average1 = 0;
            foreach (var item in vs)
            {
                average1 += item;
            }

            average1 /= vs1.Count;

            foreach (var item in vs1)
            {
                if (item > average1)
                    Console.WriteLine(item);
            }
            #endregion
        }
    }
}
