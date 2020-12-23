using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3_Exercise.Exercises
{
    public class Exercise5
    {

        int A;
        int B;
        int C;
        int D;
        //Class builder
        public Exercise5(int A, int B, int C, int D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }

        ///Method that calculates and returns the result of exercise 5.

        public void ExerciseResult()
        {

            B = C;
            Console.WriteLine("B is equal to: {0}", B);

            C = A;
            Console.WriteLine("C is equal to: {0}", C);

            A = D;
            Console.WriteLine("A is equal to: {0}", A);

            D = B; //Takes the new value of B.
            Console.WriteLine("B is equal to: {0}", D);

        }
    }
}
