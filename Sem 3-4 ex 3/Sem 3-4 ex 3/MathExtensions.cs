using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sem_3_4_ex_3
{
    static class MathExtensions
    {
        static public double StandardDeviation(int[] numbers,bool useSampleVariance = false)
        { 
            if (numbers == null || numbers.Length == 0) throw new ArgumentException("Массив не должен быть пустым!!!");
            double mathExpectation = numbers.Average();
            double sumOfSquaredDeviations = 0;
            foreach (int num in numbers)
                sumOfSquaredDeviations += (num - mathExpectation) * (num - mathExpectation);
            return sumOfSquaredDeviations / numbers.Length;

        }

        static public bool TryCalculateCircle(in double radius, 
                                            out double area, 
                                            out double length)
        {
            if (radius < 0) 
                throw new ArgumentException("Радиус должен быть неотрицательным!!!");
            area = radius * radius * Math.PI;
            length = radius * Math.PI;
            return true;
        }

        static public void SwapValues<T>(ref T leftOp, ref T rightOp)
        {
            T temp = leftOp;
            leftOp = rightOp;
            rightOp = temp;
        }


    }
}
