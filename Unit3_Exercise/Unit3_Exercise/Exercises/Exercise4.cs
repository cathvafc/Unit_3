using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3_Exercise.Exercises
{
    public class Exercise4
    {

        int N;
        //Class builder
        public Exercise4(int N)
        {
            this.N = N;
        }

        ///Method that calculates and returns the result of exercise 4.

        public void ExerciseResult()
        {
            N += 77;
            Console.WriteLine("N + 77 is: {0}", N);

            N -= 3;
            Console.WriteLine("N - 3 is: {0}", N);

            N *= 2;
            Console.WriteLine("N * 2 is: {0}", N);
        }
    }
}
