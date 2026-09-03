using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. SINGLE-LINE AND MULTI-LINE COMMENTS

            // Declare two integer variables.
            int x = 10;
            int y = 20;

            // Calculate the sum of x and y.
            int sum = x + y;

            /*
                Print the calculated sum to the console.
                This is a multi-line comment example.
            */
            Console.WriteLine("Sum = " + sum);


            // 2. IDENTIFY AND FIX ERRORS

            // Wrong:
            // int x = "10";               // Error: string cannot be assigned to int.
            // console.WriteLine(x + y);   // Error: Console must start with capital C.

            // Correct code:
            int number1 = 10;
            int number2 = 20;

            Console.WriteLine("Corrected Sum = " + (number1 + number2));


            // 3. VARIABLES AND NAMING CONVENTIONS

            // camelCase is normally used for local variables.
            string fullName = "Menna Khaled";
            int age = 19;
            double monthlySalary = 15000.50;
            bool isStudent = true;

            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Monthly Salary: " + monthlySalary);
            Console.WriteLine("Is Student: " + isStudent);

            /*
                Naming conventions make code easier to read,
                understand, maintain, and work with as a team.

                PascalCase is commonly used for:
                - Classes
                - Methods
                - Properties

                camelCase is commonly used for:
                - Local variables
                - Parameters
            */


            // 4. VALUE TYPES AND REFERENCE TYPES

            // -------- Value Type Example --------

            int value1 = 10;
            int value2 = value1;

            value2 = 20;

            Console.WriteLine("\n--- Value Type ---");
            Console.WriteLine("value1 = " + value1);
            Console.WriteLine("value2 = " + value2);

            /*
                value1 and value2 contain separate values.
                Changing value2 does not affect value1.
            */


            // -------- Reference Type Example --------

            Student student1 = new Student();
            student1.Name = "Menna";

            Student student2 = student1;

            // Both student1 and student2 refer to the same object.
            student2.Name = "Ahmed";

            Console.WriteLine("\n--- Reference Type ---");
            Console.WriteLine("student1.Name = " + student1.Name);
            Console.WriteLine("student2.Name = " + student2.Name);

            /*
                Output:
                student1.Name = Ahmed
                student2.Name = Ahmed

                student1 and student2 point to the same object.
                Therefore, changing the object through student2
                also affects what student1 sees.
            */


            // ============================================================
            // 5. ARITHMETIC OPERATIONS
            // ============================================================

            int a = 15;
            int b = 4;

            int addition = a + b;
            int difference = a - b;
            int product = a * b;
            int division = a / b;
            int remainder = a % b;

            Console.WriteLine("Sum = " + addition);
            Console.WriteLine("Difference = " + difference);
            Console.WriteLine("Product = " + product);
            Console.WriteLine("Division = " + division);
            Console.WriteLine("Remainder = " + remainder);


            // 5 - QUESTION: MODULUS OPERATOR

            int firstNumber = 2;
            int secondNumber = 7;

            Console.WriteLine("\n--- Modulus Example ---");
            Console.WriteLine(firstNumber % secondNumber);

            /*
                Output:
                2

                Because 2 is smaller than 7,
                dividing 2 by 7 gives a remainder of 2.
            */


            // 6. CHECK IF A NUMBER IS GREATER THAN 10 AND EVEN

            int number = 16;

            Console.WriteLine("\n--- Number Check ---");

            if (number > 10 && number % 2 == 0)
            {
                Console.WriteLine("The number is greater than 10 and even.");
            }
            else
            {
                Console.WriteLine("The condition is not satisfied.");
            }

            // 6 - QUESTION: && VS &

            /*
                && = Logical AND

                It is mainly used with Boolean expressions
                and supports short-circuit evaluation.

                & = Bitwise AND when used with integers.

            */



            // 7. IMPLICIT AND EXPLICIT CASTING

            Console.WriteLine("\n--- Casting ---");

            Console.Write("Enter a double value: ");

            double doubleNumber = double.Parse(Console.ReadLine());

            // Implicit casting:
            // int -> double
            double implicitCasting = doubleNumber;

            // Explicit casting:
            // double -> int
            int explicitCasting = (int)doubleNumber;

            Console.WriteLine("Original value = " + doubleNumber);
            Console.WriteLine("Implicit casting = " + implicitCasting);
            Console.WriteLine("Explicit casting = " + explicitCasting);



            // 8. AGE INPUT USING PARSE

            Console.WriteLine("\n--- Age Validation ---");

            Console.Write("Enter your age: ");

            string ageInput = Console.ReadLine();

            try
            {
                // Convert the string into an integer.
                int userAge = int.Parse(ageInput);

                // Check if the age is valid.
                if (userAge > 0)
                {
                    Console.WriteLine("Valid age.");
                }
                else
                {
                    Console.WriteLine("Invalid age.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small.");
            }


            // 9. PREFIX AND POSTFIX INCREMENT

            Console.WriteLine("\n--- Prefix and Postfix ---");

            int incrementX = 5;

            // Prefix increment:
            // x is incremented first, then used.
            Console.WriteLine("Prefix: " + ++incrementX);

            // Reset x.
            incrementX = 5;

            // Postfix increment:
            // x is used first, then incremented.
            Console.WriteLine("Postfix: " + incrementX++);

            // Now x has been incremented.
            Console.WriteLine("After postfix: " + incrementX);

        }
    }

    // STUDENT CLASS

    class Student
    {
        public string Name;
    }
}
