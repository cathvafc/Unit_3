using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3_Exercise.Exercises
{
    public class Exercise1
    {

        int firstVariable;
        int secondVariable;

        //Class builder
       public Exercise1(int firstVariable, int secondVariable)
        {
            this.firstVariable = firstVariable;
            this.secondVariable = secondVariable;
        }

        ///Method that calculates and returns the result of exercise 1.
        
         public void ExerciseResult()
        {

            Console.WriteLine("FirstVariable is equal to: {0}", firstVariable);
            Console.WriteLine("SecondVariable is equal to: {0}", secondVariable);

            Console.WriteLine("FirstVariable plus SecondVariable are equal to: {0}", firstVariable + secondVariable);
            Console.WriteLine("FirstVariable less SecondVariable are equal to: {0}", firstVariable - secondVariable);
            Console.WriteLine("FirstVariable multiplied SecondVariable are equal to: {0}", firstVariable * secondVariable);

            //If the secondVariable is zero it can not be divided by zero.
            if (secondVariable != 0)
            {
                Console.WriteLine("FirstVariable divided SecondVariable are equal to: {0}", firstVariable / secondVariable);

                Console.WriteLine("FirstVariable divided SecondVariable are equal to: {0}", firstVariable % secondVariable);
            }
            else
            {
                Console.WriteLine("Please Sir, do not divide by zero. Thank you.");
            }
           
           
            
        }
    }
}
