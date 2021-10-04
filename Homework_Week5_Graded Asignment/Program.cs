/// HomeWork 5 (Graded Assignment)    
/// File Name: Homework_Week5_Graded Asignment
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
///This is a program that will print out statistics for eight coin tosses. 
///The user will input either an “h” for heads or a “t” for tails for the eight tosses. 
///The program will then print out the total number and percentages of heads and tails.
///The increment operator will be used to increment the number of tosses as each toss is input.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week5_Graded_Asignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
       
            const int numberOftries = 8;
           double heads = 0, tails = 0;
          ;
            for(int count = 0; count < numberOftries; count++)
            {
                Console.Write("Enter h for heads or t for tails: "); //Print flip number
              string UserPickEntered = Console.ReadLine();

                if (UserPickEntered == "h")
                    heads++;
                else if (UserPickEntered == "t")
                    tails++;

                double percentageheads = (heads / numberOftries) * 100;
                double percentagetails = (tails / numberOftries) * 100;

                Console.WriteLine(" you picked " + "heads" + " " + heads + " " + "tails" + " " 
                    + tails + " " +" " +" Percent heads: " + percentageheads + "%" + 
                    " Percent tails: " + percentagetails + "%");
            }



            Console.ReadKey();

        }
    }
}
