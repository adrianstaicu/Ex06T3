using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Avand un vector de numere intregi, adunati un nr double la valorile stocate si pastrati rezultatul in alt vector corespunzator.

            int[] vectornr1 = new int[] {1, 2, 3, 4};
            double[] vectornr2 = new double[vectornr1.Length];
            double variable = 9.5;

            for (int i = 0; i < vectornr1.Length; i++)
            {
                vectornr2[i] = vectornr1[i] + variable;
            }
            for (int i = 0; i < vectornr2.Length; i++)
            {
                Console.WriteLine(vectornr1[i] + " + " + variable + " = " + vectornr2[i]);
            }
        }
    }
}

