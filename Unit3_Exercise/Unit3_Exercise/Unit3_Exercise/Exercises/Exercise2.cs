using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3_Exercise.Exercises
{
    
    public class Exercise2
    {

        int N;
        double A;
        char C;

        //Class builder
        public Exercise2(int N, double A, char C)
        {
            this.N = N;
            this.A = A;
            this.C = C;
        }

        ///Method that calculates and returns the result of exercise 2.

        public void ExerciseResult()
        {
            Console.WriteLine("N is equal to: {0}", N);
            Console.WriteLine("A is equal to: {0}", A);
            Console.WriteLine("C is equal to: {0}", C);


            Console.WriteLine("N plus A are equal to: {0}", N + A);
            Console.WriteLine("A less N is equal to: {0}", A - N);
            Console.WriteLine("The ASCII table value for C is: {0}", Convert.ToInt32(C));


        }
    }
}
