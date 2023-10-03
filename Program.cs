using System;

namespace Averagely {
    class Program
    {
         public static void Main(){
            Input();
            
         }

         public static void Input(){
            Console.WriteLine("Welcome to gpa overall counter app!");
            Console.Write("Enter the number of subjects: ");

            int SubjectNum = Convert.ToInt32(Console.ReadLine());
            decimal[] SubjectValues = new decimal[SubjectNum];

            for(int i =0; i<SubjectNum; i++)
            {
               Console.Write("Subject {0}: ",i+1);
               SubjectValues[i] = Convert.ToDecimal(Console.ReadLine());
            }

            decimal count = 0;

            for(int j =0; j < SubjectValues.Length; j++)
            {
               count += SubjectValues[j];
            }

            Console.WriteLine("Your overall gpa is {0}",Math.Round(count/SubjectNum,2));



         }

    }
}