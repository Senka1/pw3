using System;
using System.Collections.Generic;
using System.Linq;

namespace PW3_4
{
    class MyIntList
    {
        private readonly List<int> numberList = new List<int>();

        public double Average => numberList.Count > 0 ? numberList.Average() : 0;

        public double Max => numberList.Count > 0 ? numberList.Max() : 0;

        public double Min => numberList.Count > 0 ? numberList.Min() : 0;

        public void AddNumber(int number)
        {
            numberList.Add(number);
        }

        public void RemoveNumber(int number)
        {
            numberList.Remove(number);
        }
    }

    internal class Program
    {
        static void Main()
        {
            MyIntList numbers = new MyIntList();

            numbers.AddNumber(1);
            numbers.AddNumber(50);
            numbers.AddNumber(87);
            numbers.AddNumber(270);
            numbers.AddNumber(59);

            Console.WriteLine($"Максимальное число из списка: {numbers.Max}");
            Console.WriteLine($"Минимальное число из списка: {numbers.Min}");
            Console.WriteLine($"Среднее число списка равно: {numbers.Average}");
        }
    }
}
