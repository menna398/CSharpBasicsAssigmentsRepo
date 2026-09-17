namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            // Part 01 - Question 1

            Console.Write("Enter first integer: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            int y = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Result = " + x / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Operation complete");
            }


            // Part 01 - Question 2

            int numberX;
            int numberY;

            do
            {
                Console.Write("Enter positive X: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numberX) || numberX <= 0);

            do
            {
                Console.Write("Enter Y greater than 1: ");
            }
            while (!int.TryParse(Console.ReadLine(), out numberY) || numberY <= 1);

            Console.WriteLine("X = " + numberX);
            Console.WriteLine("Y = " + numberY);


            // Part 01 - Question 3

            int? nullableNumber = null;

            int result = nullableNumber ?? 10;

            Console.WriteLine("Default value = " + result);

            Console.WriteLine("HasValue = " + nullableNumber.HasValue);

            try
            {
                Console.WriteLine("Value = " + nullableNumber.Value);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Cannot access Value because the value is null.");
            }


            // Part 01 - Question 4

            int[] numbers = new int[5];

            try
            {
                Console.WriteLine(numbers[10]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index is out of range.");
            }


            // Part 01 - Question 5

            int[,] matrix = new int[3, 3];

            Console.WriteLine("Enter 9 values:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int rowSum = 0;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowSum += matrix[i, j];
                }

                Console.WriteLine("Row " + (i + 1) + " Sum = " + rowSum);
            }

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                int columnSum = 0;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    columnSum += matrix[i, j];
                }

                Console.WriteLine("Column " + (j + 1) + " Sum = " + columnSum);
            }


            // Part 01 - Question 6

            int[][] jaggedArray = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter size of row " + (i + 1) + ": ");
                int size = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }

                Console.WriteLine();
            }


            // Part 01 - Question 7

            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                name = null;
            }

            Console.WriteLine(name ?? "No name entered");

            if (name != null)
            {
                Console.WriteLine(name!);
            }


            // Part 01 - Question 8

            int value = 10;

            object obj = value;       // Boxing

            int newValue = (int)obj;  // Unboxing

            Console.WriteLine("Boxed value = " + obj);
            Console.WriteLine("Unboxed value = " + newValue);

            try
            {
                string text = (string)obj;
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid Cast.");
            }


            // Part 01 - Question 9

            int sum;
            int product;

            SumAndMultiply(5, 4, out sum, out product);

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Product = " + product);


            // Part 01 - Question 10

            PrintText("Hello", 3);

            PrintText(text: "Welcome", count: 2);


            // Part 01 - Question 11

            int[]? nullableArray = null;

            Console.WriteLine(nullableArray?.Length);


            // Part 01 - Question 12

            Console.Write("Enter day: ");
            string day = Console.ReadLine();

            int dayNumber = day.ToLower() switch
            {
                "monday" => 1,
                "tuesday" => 2,
                "wednesday" => 3,
                "thursday" => 4,
                "friday" => 5,
                "saturday" => 6,
                "sunday" => 7,
                _ => 0
            };

            Console.WriteLine(dayNumber);


            // Part 01 - Question 13

            Console.WriteLine(SumArray(1, 2, 3, 4));

            int[] arr = { 5, 10, 15 };

            Console.WriteLine(SumArray(arr));


            // Part 02 - Question 1

            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();


            // Part 02 - Question 2

            Console.Write("Enter number: ");
            int tableNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(tableNumber * i + " ");
            }

            Console.WriteLine();


            // Part 02 - Question 3

            Console.Write("Enter number: ");
            int evenNumber = int.Parse(Console.ReadLine());

            for (int i = 2; i <= evenNumber; i += 2)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();


            // Part 02 - Question 4

            Console.Write("Enter base: ");
            int baseNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine());

            int powerResult = 1;

            for (int i = 0; i < power; i++)
            {
                powerResult *= baseNumber;
            }

            Console.WriteLine(powerResult);


            // Part 02 - Question 5

            Console.Write("Enter string: ");
            string textToReverse = Console.ReadLine();

            string reversedText = "";

            for (int i = textToReverse.Length - 1; i >= 0; i--)
            {
                reversedText += textToReverse[i];
            }

            Console.WriteLine(reversedText);


            // Part 02 - Question 6

            Console.Write("Enter integer: ");
            int integerToReverse = int.Parse(Console.ReadLine());

            int reversedInteger = 0;

            while (integerToReverse != 0)
            {
                int digit = integerToReverse % 10;

                reversedInteger = reversedInteger * 10 + digit;

                integerToReverse /= 10;
            }

            Console.WriteLine(reversedInteger);


            // Part 02 - Question 7

            Console.Write("Enter array size: ");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int longestDistance = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        int distance = j - i - 1;

                        if (distance > longestDistance)
                        {
                            longestDistance = distance;
                        }
                    }
                }
            }

            Console.WriteLine("Longest distance = " + longestDistance);


            // Part 02 - Question 8

            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            Array.Reverse(words);

            Console.WriteLine(string.Join(" ", words));
        }


        // =========================
        // Methods
        // =========================

        static void SumAndMultiply(
            int x,
            int y,
            out int sum,
            out int product)
        {
            sum = x + y;
            product = x * y;
        }


        static void PrintText(string text, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(text);
            }
        }


        static int SumArray(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}