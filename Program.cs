using System;

namespace BasicMath
{
    // Define a public class called "BasicMath"
    public class BasicMath
    {
        // Define a public method called "add" that takes two double parameters "a" and "b", and returns their sum
        public double add(double a, double b)
        {
            return a + b;
        }

        // Define a public method called "subtract" that takes two double parameters "a" and "b", and returns their difference
        public double subtract(double a, double b)
        {
            return a - b;
        }

        // Define a public method called "divide" that takes two double parameters "a" and "b", and returns their quotient
        public double divide(double a, double b)
        {
            // Check if the value of "b" is zero
            if (b == 0)
            {
                // If "b" is zero, throw a "DivideByZeroException" with the message "Cannot divide by zero"
                throw new DivideByZeroException("Cannot divide by zero");
            }
            // If "b" is not zero, return the quotient of "a" and "b"
            return a / b;
        }

        // Define a public method called "multiply" that takes two double parameters "a" and "b", and returns their product
        public double multiply(double a, double b)
        {
            return a * b;
        }
    }
}