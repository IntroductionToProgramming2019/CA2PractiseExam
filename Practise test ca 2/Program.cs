/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : CA2 Practise Exam
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_test_ca_2
{
    class Program
    {
        static int[] TotalScore = new int[100];
        static string[] gender = new string[100];
        static int[] Males = new int[100];
        static int[] Females = new int[100];
        static int AsMales = 0;
        static int BsMales = 0;
        static int CsMales = 0;
        static int DsMales = 0;
        static int AsFemales = 0;
        static int BsFemales = 0;
        static int CsFemales = 0;
        static int DsFemales = 0;
        static int numFemales = 0;
        static int numMales = 0;

        static void Main(string[] args)
        {
            int i = 0;
            int input = 0;
            int totalMales = 0;
            int totalFemales = 0;
            do
            {

                Console.WriteLine("Enter your test score:");
                input = int.Parse(Console.ReadLine());
                if (input == -999)
                {
                    break;
                }
                TotalScore[i] = input;
                Console.WriteLine("Please enter your gender(male or female): ");
                string gender = Console.ReadLine().ToLower();
                int band = input / 10;
                if (gender == "male")
                {
                    Males[i] = input;
                    totalMales++;
                    Females[i] = 0;

                    MaleGrades(band);
                }
                else if (gender == "female")
                {
                    Females[i] = input;
                    totalFemales++;
                    Males[i] = 0;

                    FemaleGrades(band);
                }
            } while (input != -999);
            OutPut();
        }
        static void MaleGrades(int band)
        {

            switch (band + 1)
            {
                case 1:
                case 2:
                case 3:
                    DsMales++;
                    break;

                case 4:
                case 5:
                    CsMales++;
                    break;

                case 6:
                case 7:
                    BsMales++;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                    AsMales++;
                    break;
            }

        }
        static void FemaleGrades(int band)
        {

            switch (band + 1)
            {
                case 1:
                case 2:
                case 3:
                    DsFemales++;
                    break;

                case 4:
                case 5:
                    CsFemales++;
                    break;

                case 6:
                case 7:
                    BsFemales++;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                    AsFemales++;
                    break;
            }
        }
        static void OutPut()
        {
            numFemales = AsFemales + BsFemales + CsFemales + DsFemales;
            numMales = AsMales + BsMales + CsMales + DsMales;

            Console.WriteLine("Grade Band       Female Count        Male Count      Total Count");
            Console.WriteLine("0 - 39               {0}                 {1}             {2}", DsFemales, DsMales, DsMales + DsFemales);
            Console.WriteLine("40 - 59             {0}                 {1}             {2}", CsFemales, CsMales, CsMales + CsFemales);
            Console.WriteLine("60 - 79             {0}                 {1}             {2}", BsFemales, BsMales, BsMales + BsFemales);
            Console.WriteLine("80 - 100              {0}                 {1}             {2}", AsFemales, AsMales, AsMales + AsFemales);
            Console.WriteLine("Total                {0}                 {1}                 {2}", numFemales, numMales, numFemales + numMales);
        }
    }
}
