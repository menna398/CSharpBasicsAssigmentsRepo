using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            /*
                - Accept a string input from the user.
                - Convert it to an integer using int.Parse
                  and Convert.ToInt32.
                - Handle exceptions using try-catch.
            */

            Console.WriteLine("===============");

            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            try
            {
                int numberUsingParse = int.Parse(input);

                int numberUsingConvert = Convert.ToInt32(input);

                Console.WriteLine("Using int.Parse: " + numberUsingParse);
                Console.WriteLine("Using Convert.ToInt32: " + numberUsingConvert);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is outside the range of int.");
            }


            /*
                Question:
                What is the difference between int.Parse and
                Convert.ToInt32 when handling null inputs?

                int.Parse(null)
                -> Throws ArgumentNullException.

                Convert.ToInt32(null)
                -> Returns 0.
            */


            // 2.
            /*
                Problem:
                - Prompts the user to input a number.
                - Use int.TryParse to check if it is a valid integer.
                - If valid, print the number.
                - Otherwise, print an error message.
            */

            Console.WriteLine("\n===============");

            Console.Write("Enter a number: ");
            string numberInput = Console.ReadLine();

            if (int.TryParse(numberInput, out int number))
            {
                Console.WriteLine("The number is: " + number);
            }
            else
            {
                Console.WriteLine("Error: Invalid integer.");
            }

            /*
                Question:
                Why is TryParse recommended over Parse in user-facing
                applications?

                TryParse does not throw an exception when the user enters
                invalid input.
            */


            // 3.
            /*
                Problem:
                - Declare an object variable.
                - Assign it different data types:
                  int, string, double.
                - Print GetHashCode() for each assignment.
            */

            Console.WriteLine("\n===============");

            object obj;

            obj = 10;
            Console.WriteLine("Hash Code: " + obj.GetHashCode());

            obj = "Hello";
            Console.WriteLine("Hash Code: " + obj.GetHashCode());

            obj = 10.5;
            Console.WriteLine("Hash Code: " + obj.GetHashCode());
            /*
                Question:
                Explain the real purpose of the GetHashCode() method. 

                GetHashCode() returns an integer hash code that represents
                the value of an object.

                It is mainly used by hash-based collections such as:

                - Dictionary<TKey, TValue>
                - HashSet<T>
            */


            // 4. 

            /*
                Problem:
                - Create an object and assign it a value.
                - Create a second reference to the same object.
                - Modify the object using one reference.
                - Print the value using the other reference.
            */

            Console.WriteLine("\n================");

            Person person1 = new Person();
            person1.Name = "Menna";

            Person person2 = person1;

            person2.Name = "Ahmed";

            Console.WriteLine("person1.Name = " + person1.Name);
            Console.WriteLine("person2.Name = " + person2.Name);

            /*
                Question:
                What is the significance of reference equality in .NET?

                Reference equality checks whether two references point
                to the exact same object in memory.
            */

            Console.WriteLine(ReferenceEquals(person1, person2));


            // 5. 

            /*
                Problem:
                - Declare a string.
                - Modify it by concatenating "Hi Willy".
                - Print GetHashCode() before and after modification.
            */

            Console.WriteLine("\n================");

            string message = "Hello";

            Console.WriteLine("Before:");
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Hash Code: " + message.GetHashCode());

            // Concatenation creates a NEW string.
            message = message + " Hi Willy";

            Console.WriteLine("\nAfter:");
            Console.WriteLine("Message: " + message);
            Console.WriteLine("Hash Code: " + message.GetHashCode());

            /*
                Question:
                Why is string immutable in C#?

                Strings are immutable, which means that once a string
                object is created, its contents cannot be changed.
            */



            // 6. 
            /*
                Problem:
                - Use StringBuilder to append text to "Hi Willy".
                - Print GetHashCode() before and after modification.
            */

            Console.WriteLine("\n==============");

            StringBuilder builder = new StringBuilder("Hi Willy");

            Console.WriteLine("Before:");
            Console.WriteLine("Text: " + builder);
            Console.WriteLine("Hash Code: " + builder.GetHashCode());

            // Modify the same StringBuilder object.
            builder.Append("! Welcome to C#.");

            Console.WriteLine("\nAfter:");
            Console.WriteLine("Text: " + builder);
            Console.WriteLine("Hash Code: " + builder.GetHashCode());

            /*
                Question:
                How does StringBuilder address the inefficiencies
                of string concatenation?

                String is immutable.
                Therefore, repeated concatenation can create many
                temporary string objects.

                StringBuilder uses a mutable internal buffer.
                It can modify its content in that buffer instead of
                creating a new string object for every operation.
            */


            /*
                Question:
                Why is StringBuilder faster for large-scale
                string modifications?

                Because StringBuilder reduces the number of temporary
                string objects created during repeated modifications.

                It is especially useful when performing many operations
                such as Append, Insert, Replace, and Remove.
            */


            // 7. 
            /*
                Problem:
                - Accept two integer inputs.
                - Display the sum using:
                    1. Concatenation (+)
                    2. string.Format()
                    3. String interpolation ($)
            */

            Console.WriteLine("\n=============");

            Console.Write("Enter first integer: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int input2 = int.Parse(Console.ReadLine());

            int total = input1 + input2;

            // 1. Concatenation
            Console.WriteLine("Sum is " + input1 + input2);

            // 2. Composite Formatting
            Console.WriteLine(
                string.Format("Sum is {0}", input1 + input2)
            );

            // 3. String Interpolation
            Console.WriteLine($"Sum is {input1 + input2}");


            /*
                Question:
                Which string formatting method is most used and why?

                String interpolation is generally the most convenient
                and commonly preferred modern style in C#.
            */


            // 8. 
            /*
                Problem:
                Create a program using StringBuilder to:
                - Append text.
                - Replace a substring.
                - Insert a string at a specific position.
                - Remove a portion of text.
            */

            Console.WriteLine("\n==============");

            StringBuilder text = new StringBuilder("Hello World");

            // Append
            text.Append("!");
            Console.WriteLine("After Append:");
            Console.WriteLine(text);


            // Replace
            text.Replace("World", "C#");
            Console.WriteLine("\nAfter Replace:");
            Console.WriteLine(text);

            // Insert
            text.Insert(6, "Beautiful ");
            Console.WriteLine("\nAfter Insert:");
            Console.WriteLine(text);

            // Remove
            text.Remove(6, 10);
            Console.WriteLine("\nAfter Remove:");
            Console.WriteLine(text);

            /*
                Question:
                Explain how StringBuilder is designed to handle frequent
                modifications compared to strings.

                StringBuilder is mutable.

                Its internal character buffer can be modified directly,
                allowing operations such as:

                - Append()
                - Insert()
                - Remove()
                - Replace()

                without creating a completely new StringBuilder object
                for every modification.

                In contrast, strings are immutable, so every operation
                that appears to modify a string actually produces a
                new string object.
            */
        }
    }

    // Person Class
    class Person
    {
        public string Name;
    }
}

