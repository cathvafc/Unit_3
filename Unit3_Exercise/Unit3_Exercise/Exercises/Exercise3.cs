using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3_Exercise.Exercises
{
    public class Exercise3
    {
        int X;
        int Y;
        double N;
        double M;

        //Class builder
        public Exercise3(int X, int Y, double N, double M)
        {
            this.X = X;
            this.Y = Y;
            this.N = N;
            this.M = M;
        }

        ///Method that calculates and returns the result of exercise 3.

        public void ExerciseResult()
        {
            Console.WriteLine("X value is: {0}", X);
            Console.WriteLine("Y value is: {0}", Y);
            Console.WriteLine("N value is: {0}", N);
            Console.WriteLine("M value is: {0}", M);

            Console.WriteLine("X + Y: {0}", X+Y);
            Console.WriteLine("X - Y: {0}", X-Y);
            Console.WriteLine("X * Y: {0}", X*Y);

            if (Y != 0)
            {
                Console.WriteLine("X / Y: {0}", X / Y);
                Console.WriteLine("X % Y: {0}", X % Y);
            }

            Console.WriteLine("N + M: {0}", N + M);
            Console.WriteLine("N - M: {0}", N - M);
            Console.WriteLine("N * M: {0}", N * M);

            if (M != 0)
            {
                Console.WriteLine("N / M: {0}", N / M);
                Console.WriteLine("N % M: {0}", N % M);
            }

            Console.WriteLine("X + N: {0}", X + N);

            if (M != 0)
            {
                Console.WriteLine("Y / M: {0}", Y / M);
                Console.WriteLine("Y % M: {0}", Y % M);
            }

            Console.WriteLine("X*2 value is: {0}", X*2);
            Console.WriteLine("Y*2 value is: {0}", Y*2);
            Console.WriteLine("N*2 value is: {0}", N*2);
            Console.WriteLine("M*2 value is: {0}", M*2);

            Console.WriteLine("X+Y+N+M = {0}", X+Y+N+M);
            Console.WriteLine("X*Y*N*M = {0}", X*Y*N*M);

        }
    }
}
