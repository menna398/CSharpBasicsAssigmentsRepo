namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            /*
                Problem:
                Initialize a one-dimensional array in three different ways:
                1. new int[size]
                2. initializer list
                3. Array syntax sugar
                Then assign values and print them.
            */

            Console.WriteLine("===============");

            int[] arr1 = new int[3];
            arr1[0] = 10;
            arr1[1] = 20;
            arr1[2] = 30;
            Console.WriteLine("Array 1:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            int[] arr2 = new int[] { 40, 50, 60 };
            Console.WriteLine("\nArray 2:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            int[] arr3 = { 70, 80, 90 };
            Console.WriteLine("\nArray 3:");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            // Demonstrate IndexOutOfRangeException
            try
            {
                Console.WriteLine(arr1[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\nIndexOutOfRangeException occurred!");
            }


            /*
                Question:
                What is the default value assigned to array elements in C#?

                Array elements are automatically initialized with
                the default value of their data type.
            */


            // 2. 
            /*
                Problem:
                - Create two arrays.
                - Perform a shallow copy.
                - Demonstrate how modifying one affects the other.
                - Perform a deep copy using Clone().
                - Show that modifications do not affect the copied array.
            */

            Console.WriteLine("\n============");

            int[] originalArray = { 10, 20, 30 };

            int[] shallowCopy = originalArray;
            shallowCopy[0] = 100;

            Console.WriteLine("\nAfter shallow copy modification:");

            Console.WriteLine("Original Array:");
            PrintArray(originalArray);

            Console.WriteLine("Shallow Copy:");
            PrintArray(shallowCopy);
            /*
                Both arrays show:

                100 20 30

                Because originalArray and shallowCopy
                refer to the same array object.
            */

            int[] originalArray2 = { 10, 20, 30 };

            int[] deepCopy = (int[])originalArray2.Clone();

            deepCopy[0] = 100;

            Console.WriteLine("\nAfter deep copy modification:");

            Console.WriteLine("Original Array:");
            PrintArray(originalArray2);

            Console.WriteLine("Deep Copy:");
            PrintArray(deepCopy);
            /*
                Original:
                10 20 30

                Deep Copy:
                100 20 30

                The original array is not affected because Clone()
                creates a separate array object.
            */


            /*
                Question:
                What is the difference between Array.Clone()
                and Array.Copy()?

                Array.Clone():
                - Creates a shallow copy of the array.
                - Returns an object, so casting is usually needed.
                - Copies all elements into a new array.

                Array.Copy():
                - Copies elements from one array to another.
                - Allows selecting the source and destination positions.
                - Can copy only a specific number of elements.
            */


            // 3.
            /*
                Problem:
                - Create a 2D array for 3 students and 3 subjects.
                - Take input from the user.
                - Print grades using nested loops.
            */

            Console.WriteLine("\n==============");

            int[,] grades = new int[3, 3];

            for (int student = 0; student < grades.GetLength(0); student++)
            {
                Console.WriteLine("\nEnter grades for Student " + (student + 1));

                for (int subject = 0; subject < grades.GetLength(1); subject++)
                {
                    Console.Write("Subject " + (subject + 1) + ": ");

                    while (!int.TryParse(Console.ReadLine(), out grades[student, subject]))
                    {
                        Console.Write("Invalid input. Enter an integer: ");
                    }
                }
            }


            // Print the grades.
            Console.WriteLine("\nStudent Grades:");

            for (int student = 0; student < grades.GetLength(0); student++)
            {
                Console.Write("Student " + (student + 1) + ": ");

                for (int subject = 0; subject < grades.GetLength(1); subject++)
                {
                    Console.Write(grades[student, subject] + "\t");
                }

                Console.WriteLine();
            }


            /*
                Question:
                What is the difference between GetLength() and Length
                for multidimensional arrays?

                Length:
                Returns the total number of elements in all dimensions.
                GetLength(dimension):
                Returns the number of elements in a specific dimension.
            */


            // 4.
            /*
                Problem:
                Demonstrate at least 5 array methods:
                1. Sort()
                2. Reverse()
                3. IndexOf()
                4. Copy()
                5. Clear()
            */

            Console.WriteLine("\n==============");

            int[] numbers = { 50, 20, 40, 10, 30 };

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            Array.Sort(numbers);
            Console.WriteLine("\nAfter Sort():");
            PrintArray(numbers);

            Array.Reverse(numbers);
            Console.WriteLine("\nAfter Reverse():");
            PrintArray(numbers);

            int index = Array.IndexOf(numbers, 30);
            Console.WriteLine("\nIndex of 30: " + index);

            int[] copiedNumbers = new int[numbers.Length];
            Array.Copy(numbers, copiedNumbers, numbers.Length);

            Console.WriteLine("\nAfter Copy():");
            Console.WriteLine("Original:");
            PrintArray(numbers);

            Console.WriteLine("Copied:");
            PrintArray(copiedNumbers);

            Array.Clear(copiedNumbers, 0, copiedNumbers.Length);
            Console.WriteLine("\nAfter Clear():");
            PrintArray(copiedNumbers);

            /*
                Question:
                What is the difference between Array.Copy()
                and Array.ConstrainedCopy()?

                Array.Copy():
                - Copies elements from one array to another.
                - If an exception occurs during copying, the destination
                  array may be partially modified.

                Array.ConstrainedCopy():
                - Provides stronger guarantees.
                - If the operation cannot complete successfully,
                  the destination array is not left partially modified
                  by the failed copy operation.
            */


            // 5. 
            /*
                Problem:
                - Use for to print all elements.
                - Use foreach to print all elements.
                - Use while to print all elements in reverse order.
            */

            Console.WriteLine("\n===============");

            int[] loopArray = { 10, 20, 30, 40, 50 };

            Console.WriteLine("\nUsing for loop:");
            for (int i = 0; i < loopArray.Length; i++)
            {
                Console.WriteLine(loopArray[i]);
            }

            Console.WriteLine("\nUsing foreach loop:");
            foreach (int item in loopArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nUsing while loop in reverse:");
            int indexCounter = loopArray.Length - 1;
            while (indexCounter >= 0)
            {
                Console.WriteLine(loopArray[indexCounter]);

                indexCounter--;
            }

            /*
                Question:
                Why is foreach preferred for read-only operations on arrays?

                - It is simple and readable.
                - It automatically moves through all elements.
                - It does not require managing an index.
                - It reduces the chance of index-related errors.
            */


            // 6.
            /*
                Problem:
                Repeatedly ask the user for a positive odd number.
                - Use int.TryParse()
                - Use do-while
                - Validate the input.
            */

            Console.WriteLine("\n==============");

            int oddNumber;

            do
            {
                Console.Write("Enter a positive odd number: ");

                string oddInput = Console.ReadLine();

                if (!int.TryParse(oddInput, out oddNumber))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");

                    oddNumber = 0;
                    continue;
                }

                if (oddNumber <= 0)
                {
                    Console.WriteLine("The number must be positive.");
                }
                else if (oddNumber % 2 == 0)
                {
                    Console.WriteLine("The number must be odd.");
                }

            } while (oddNumber <= 0 || oddNumber % 2 == 0);

            Console.WriteLine("Valid number: " + oddNumber);


            /*
                Question:
                Why is input validation important when working
                with user inputs?

                User input cannot always be trusted.
            */


            // 7.
            /*
                Problem:
                - Create a 2D array with fixed values.
                - Print it in matrix format.
            */

            Console.WriteLine("\n==============");

            int[,] matrix =
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + "\t");
                }

                Console.WriteLine();
            }


            /*
                Question:
                How can you format the output of a 2D array
                for better readability?

                - \t for tab spacing.
                - String interpolation.
                - Composite formatting.
                - Padding using PadLeft() or PadRight().
            */


            // 8.
            /*
                Problem:
                - Ask the user for a month number.
                - Use if-else to determine the month name.
                - Use switch to do the same thing.
            */

            Console.WriteLine("\n==============");

            Console.Write("Enter month number (1-12): ");
            int month;
            while (!int.TryParse(Console.ReadLine(), out month) ||
                   month < 1 ||
                   month > 12)
            {
                Console.Write("Invalid month. Enter a number from 1 to 12: ");
            }

            string monthNameIfElse;

            if (month == 1)
                monthNameIfElse = "January";
            else if (month == 2)
                monthNameIfElse = "February";
            else if (month == 3)
                monthNameIfElse = "March";
            else if (month == 4)
                monthNameIfElse = "April";
            else if (month == 5)
                monthNameIfElse = "May";
            else if (month == 6)
                monthNameIfElse = "June";
            else if (month == 7)
                monthNameIfElse = "July";
            else if (month == 8)
                monthNameIfElse = "August";
            else if (month == 9)
                monthNameIfElse = "September";
            else if (month == 10)
                monthNameIfElse = "October";
            else if (month == 11)
                monthNameIfElse = "November";
            else
                monthNameIfElse = "December";

            Console.WriteLine("Using if-else: " + monthNameIfElse);


            string monthNameSwitch;

            switch (month)
            {
                case 1:
                    monthNameSwitch = "January";
                    break;

                case 2:
                    monthNameSwitch = "February";
                    break;

                case 3:
                    monthNameSwitch = "March";
                    break;

                case 4:
                    monthNameSwitch = "April";
                    break;

                case 5:
                    monthNameSwitch = "May";
                    break;

                case 6:
                    monthNameSwitch = "June";
                    break;

                case 7:
                    monthNameSwitch = "July";
                    break;

                case 8:
                    monthNameSwitch = "August";
                    break;

                case 9:
                    monthNameSwitch = "September";
                    break;

                case 10:
                    monthNameSwitch = "October";
                    break;

                case 11:
                    monthNameSwitch = "November";
                    break;

                case 12:
                    monthNameSwitch = "December";
                    break;

                default:
                    monthNameSwitch = "Invalid month";
                    break;
            }

            Console.WriteLine("Using switch: " + monthNameSwitch);


            /*
                Question:
                When should you prefer switch over if-else?

                - We are comparing one value against many fixed values.
                - The possible cases are clearly defined.
                - We want cleaner and more readable code.
            */


            // 9.

            /*
                Problem:
                - Sort an integer array using Array.Sort().
                - Search for a value using:
                    Array.IndexOf()
                    Array.LastIndexOf()
            */

            Console.WriteLine("\n===============");

            int[] searchArray = { 40, 10, 30, 20, 30, 50 };

            Console.WriteLine("Before sorting:");
            PrintArray(searchArray);


            // Sort the array.
            Array.Sort(searchArray);

            Console.WriteLine("\nAfter sorting:");
            PrintArray(searchArray);


            // Search for the first occurrence of 30.
            int firstIndex = Array.IndexOf(searchArray, 30);

            // Search for the last occurrence of 30.
            int lastIndex = Array.LastIndexOf(searchArray, 30);

            Console.WriteLine("\nFirst index of 30: " + firstIndex);
            Console.WriteLine("Last index of 30: " + lastIndex);


            /*
                Question:
                What is the time complexity of Array.Sort()?

                O(n log n)
                where n is the number of elements.
            */


            // 10. 
            /*
                Problem:
                - Create an integer array.
                - Calculate the sum using a for loop.
                - Calculate the sum using a foreach loop.
            */

            Console.WriteLine("\n===== 10. Sum Using for and foreach =====");

            int[] sumArray = { 10, 20, 30, 40, 50 };

            int sumUsingFor = 0;

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumUsingFor += sumArray[i];
            }

            Console.WriteLine("Sum using for: " + sumUsingFor);


            int sumUsingForeach = 0;

            foreach (int value in sumArray)
            {
                sumUsingForeach += value;
            }

            Console.WriteLine("Sum using foreach: " + sumUsingForeach);


            /*
                Question:
                Which loop is more efficient for calculating the sum
                of an array, for or foreach, and why?

                Answer:
                Both loops have O(n) time complexity.

                foreach is often preferred when we only need to read
                every element because it is simpler and more readable.
            */
        }
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
