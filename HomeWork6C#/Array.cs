using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6C_
{
    internal class Array : ICalc, IOutput2, ICalc2
    {
        private int[] elements;

        public Array(int[] elements)
        {
            this.elements = elements ?? throw new ArgumentNullException(nameof(elements));
        }

        public int Less(int valueToCompare)
        {
            return elements.Count(e => e < valueToCompare);
        }

        public int Greater(int valueToCompare)
        {
            return elements.Count(e => e > valueToCompare);
        }

        public void ShowEven()
        {
            var evenElements = elements.Where(e => e % 2 == 0);
            Console.WriteLine($"Парні елементи: {string.Join(", ", evenElements)}");
        }

        public void ShowOdd()
        {
            var oddElements = elements.Where(e => e % 2 != 0);
            Console.WriteLine($"Непарні елементи: {string.Join(", ", oddElements)}");
        }

        public int CountDistinct()
        {
            return elements.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            return elements.Count(e => e == valueToCompare);
        }

        public void Print()
        {
            Console.WriteLine($"Array elements: {string.Join(", ", elements)}");
        }
    }
}
