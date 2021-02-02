using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilyanNikolovS4InClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A;
            int B;
            int C;
            int D;

            double a;
            double b;
            double c;
            double d;

            int totalSum;
            int lastTwo;
            int totalSumAndlastTwo;
            int subtractFromLastTwo;

            string strA;
            string strB;
            string strC;
            string strD;
            string strE = "";
            string strF = "";
            string strG = "";
            string strH = "";

            Boolean flag = true;

            Console.Write("Please enter four three-digit numbers\n");

            strA = Console.ReadLine();
            if (int.TryParse(strA, out A))
            {
                A = int.Parse(strA);
            }
            else
            {
                strE = "Numeric value required for this Number\n";
                flag = false;
                Console.WriteLine(strE);
            }

            strB = Console.ReadLine();
            if (int.TryParse(strB, out B))
            {
                B = int.Parse(strB);
            }
            else
            {
                strF = "Numeric value required for this Number\n";
                flag = false;
                Console.WriteLine(strF);
            }

            strC = Console.ReadLine();
            if (int.TryParse(strC, out C))
            {
                C = int.Parse(strC);
            }
            else
            {
                strG = "Numeric value required for this Number\n";
                flag = false;
                Console.WriteLine(strG);
            }

            strD = Console.ReadLine();
            if (int.TryParse(strD, out D))
            {
                D = int.Parse(strD);
            }
            else
            {
                strH = "Numeric value required for this Number\n";
                flag = false;
                Console.WriteLine(strH);
            }

            a = Convert.ToDouble(strA);
            b = Convert.ToDouble(strB);
            c = Convert.ToDouble(strC);
            d = Convert.ToDouble(strD);

            A = int.Parse(strA);
            B = int.Parse(strB);
            C = int.Parse(strC);
            D = int.Parse(strD);


            totalSum = A + B + C + D;

            Console.WriteLine(totalSum);

            lastTwo = C * D;

            Console.WriteLine(lastTwo);

            totalSumAndlastTwo = totalSum + lastTwo;

            Console.WriteLine(totalSumAndlastTwo);

            subtractFromLastTwo = lastTwo - D;

            Console.WriteLine(subtractFromLastTwo);

            //User can enter a number that consist of more or less than 4 digit.
        }
    }
}
