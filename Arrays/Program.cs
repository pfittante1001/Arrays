﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int [] vacation = new int[] {1 ,2 ,3 ,4, 5};

            //Console.WriteLine(vacation[0] + " " + vacation[4]);

            //string place = "";
            //int[] ages = new int[3];

            //for (int i = 0; i < 3; i++)
            //{



            //    if (i == 0)
            //    {
            //        place = "first";

            //    }else if (i == 1)
            //    {
            //        place = "second";
            //    }
            //    else
            //    {
            //        place = "third";
            //    }

            //    Console.Write("Please enter the ages of three children you know: ");
            //    Console.Write("\nPlease enter the {0} ", place);
            //    string agesStr = Console.ReadLine();
            //    ages[i] = int.Parse(agesStr);

            //}
            //Console.WriteLine("The ages you entered are {0}, {1}, {2}.", ages[0], ages[1], ages[2]);

            //string gradeStr = "";

            //decimal[] stuGrades = new decimal[8];

            //decimal totalGrades = 0.00m;

            //decimal GPA;

            //Console.WriteLine("Please enter you grades for the semester, and I will give you your gpa ");

            //for(int i = 0; i < 8; i++)
            //{
            //    gradeStr = Console.ReadLine();
            //    char grade = char.Parse(gradeStr);

            //    if (grade == 'a')
            //    {
            //        stuGrades[i] = 4.0m;

            //    } else if (grade == 'b')
            //    {
            //        stuGrades[i] = 3.0m;

            //    }else if (grade == 'c')
            //    {
            //        stuGrades[i] = 2.0m;

            //    }else if (grade == 'd')
            //    {
            //        stuGrades[i] = 1.0m;
            //    }else
            //    {
            //        stuGrades[i] = 0.0m;
            //    }

            //    //stuGrades[i] = double.Parse(grade);
            //    totalGrades = totalGrades + stuGrades[i];
            //    Console.WriteLine(totalGrades);

            //}

            //GPA = totalGrades / stuGrades.Length;

            //Console.WriteLine("Your GPA " + GPA);

            //int[] arrayIntFwd = new int[100];
            //int[] arrayIntRev = new int[100];
            //Console.WriteLine("make array");
            //for (int i = 0; i < 100; i++)
            //{
            //    arrayIntFwd[i] = i + 1;


            //    Console.Write(arrayIntFwd[i]);

            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Array.Reverse(arrayIntFwd);

            //for (int i = 0; i < 100; i++)
            //{

            //    Console.Write(arrayIntFwd[i]);

            //}

            //Console.WriteLine();
            //Console.WriteLine();
            //int j = 1;
            //Console.WriteLine("reverse array");
            //for (int i = 0; i < 100; i++)
            //{
            //        if (arrayIntFwd[i] < arrayIntFwd[j])
            //        {

            //            for (j = 0; j < 99; j++)
            //            {

            //                int temp = arrayIntFwd[i];
            //                arrayIntFwd[i] = arrayIntFwd[j];
            //                arrayIntFwd[j] = temp; 
            //            }

            //        }

            //    Console.Write(arrayIntFwd[i]);
            //  }









            //Console.WriteLine();
            //for (int i = 0; i <= 99; i++)
            //{

            //    Console.Write(arrayIntFwd[i]);
            //}


            //string[] namesArray = new string[5];
            //String nameUpper;
            
            //string nameCompare;
            //string nameCompUpper;
            //Console.WriteLine("Enter five names:");

            //for(int i = 0; i <= 4; i++)
            //{
            //    nameUpper = Console.ReadLine();
            //    nameUpper.ToUpper();
            //    namesArray[i] = nameUpper;
                
            //}

            //Console.WriteLine("chosose what name you would like to print. ");
            //nameCompare = Console.ReadLine();
            //nameCompUpper = nameCompare.ToUpper();

            //int indx = Array.IndexOf(namesArray, nameCompUpper);

            //Console.WriteLine("The name {0} you are searching for is at index {1}.", nameCompare, indx);



            int[] luckyNum = new int[50];
            Random randNum = new Random();
            int minRan = 0;
            int maxRan = 50;
            string userChoiceStr;

            for (int i = 0; i < luckyNum.Length; i++)
            {
                luckyNum[i] = randNum.Next(minRan, maxRan);
            }

            Console.WriteLine("Pick a lucky number between 0 and 50 and I will tell you the index where the number is located ");
            userChoiceStr = Console.ReadLine();
            int userChoice = int.Parse(userChoiceStr);
            int indx = Array.LastIndexOf(luckyNum, userChoice);

            Console.WriteLine("The number you chose {0} is located in index {1}.", userChoice, indx);
        }



    }
}
