using System.Text;

namespace HomeWork6C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = UTF8Encoding.UTF8;
            Console.OutputEncoding = UTF8Encoding.UTF8;

            //Task 1, 2 and 3
            int[] data = { 5, 10, 15, 20, 25, 10, 15, 5 };
            Array array = new Array(data);

            array.Print();

            Console.WriteLine($"Кількість унікальних значень: {array.CountDistinct()}");

            int valueToCompare = 10;
            Console.WriteLine($"Кількість елементів рівних {valueToCompare}: {array.EqualToValue(valueToCompare)}");

            array.ShowEven();
            array.ShowOdd();
            Console.WriteLine($"Кількість елементів менших за 15: {array.Less(15)}");
            Console.WriteLine($"Кількість елементів більших за 15: {array.Greater(15)}");


        }
    }
}
