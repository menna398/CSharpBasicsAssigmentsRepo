namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //1
            IVehicle car = new Car();
            IVehicle bike = new Bike();

            car.StartEngine();
            car.StopEngine();

            Console.WriteLine();

            bike.StartEngine();
            bike.StopEngine();

            ///////////
            Console.WriteLine("==============");

            //2

            Shape rectangle = new Rectangle(5, 4);
            Shape circle = new Circle(3);

            rectangle.Display();
            Console.WriteLine($"Rectangle Area = {rectangle.GetArea()}");

            Console.WriteLine();

            circle.Display();
            Console.WriteLine($"Circle Area = {circle.GetArea()}");

            ///////////
            Console.WriteLine("==============");

            //3

            Product[] products =
            {
                new Product(1, "Laptop", 30000),
                new Product(2, "Mouse", 500),
                new Product(3, "Keyboard", 1500),
                new Product(4, "Monitor", 8000)
            };

            Array.Sort(products);

            foreach (Product product in products)
            {
                Console.WriteLine(
                    $"{product.Name} - {product.Price}"
                );
            }

            ///////////
            Console.WriteLine("==============");

            //4

            Student student1 = new Student(1, "Menna", 95);

            // Shallow copy
            Student student2 = student1;

            // Deep copy using copy constructor
            Student student3 = new Student(student1);

            student2.Name = "Ahmed";
            student3.Name = "Mona";

            Console.WriteLine("Original:");
            Console.WriteLine(student1.Name);

            Console.WriteLine("Shallow Copy:");
            Console.WriteLine(student2.Name);

            Console.WriteLine("Deep Copy:");
            Console.WriteLine(student3.Name);

            ///////////
            Console.WriteLine("==============");

            //5

            Robot robot = new Robot();

            robot.Walk();

            IWalkable walkableRobot = robot;

            walkableRobot.Walk();


            ///////////
            Console.WriteLine("==============");

            //6

            Account account = new Account();

            account.Id = 1;
            account.Holder = "Menna";
            account.AccountBalance = 5000;

            Console.WriteLine($"ID: {account.Id}");
            Console.WriteLine($"Holder: {account.Holder}");
            Console.WriteLine($"Balance: {account.AccountBalance}");

            ///////////
            Console.WriteLine("==============");

            //7

            ILogger logger = new ConsoleLogger();

            logger.Log();

            ///////////
            Console.WriteLine("==============");

            //8

            Book book1 = new Book();
            Book book2 = new Book("Clean Code");
            Book book3 = new Book("Clean Code", "Robert Martin");

            Console.WriteLine($"{book1.Title} - {book1.Author}");
            Console.WriteLine($"{book2.Title} - {book2.Author}");
            Console.WriteLine($"{book3.Title} - {book3.Author}");

            ///////////
            Console.WriteLine("==============");

            //part 2

            Console.WriteLine("Square Series:");

            IShapeSeries squareSeries = new SquareSeries();
            PrintTenShapes(squareSeries);

            Console.WriteLine();

            Console.WriteLine("Circle Series:");

            IShapeSeries circleSeries = new CircleSeries();
            PrintTenShapes(circleSeries);

            Shape2[] shapes =
            {
                new Shape2("Square", 25),
                new Shape2("Circle", 12.56),
                new Shape2("Rectangle", 40),
                new Shape2("Circle", 50),
                new Shape2("Square", 9)
            };

            Array.Sort(shapes);

            foreach (Shape2 shape in shapes)
            {
                Console.WriteLine($"{shape.Name} - Area: {shape.Area}");
            }

            GeometricShape rectangle2 = new Rectangle2(5, 4);

            Console.WriteLine("Rectangle");
            Console.WriteLine($"Area: {rectangle2.CalculateArea()}");
            Console.WriteLine($"Perimeter: {rectangle2.Perimeter}");

            Console.WriteLine();

            GeometricShape triangle = new Triangle(6, 4);

            Console.WriteLine("Triangle");
            Console.WriteLine($"Area: {triangle.CalculateArea()}");

            Shape2[] shapes2 =
           {
                new Shape2("Square", 25),
                new Shape2("Circle", 12),
                new Shape2("Rectangle", 40),
                new Shape2("Square", 9)
            };

            int[] areas = new int[shapes.Length];

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = (int)shapes[i].Area;
            }

            SelectionSort2(areas);

            Console.WriteLine("Sorted Areas:");

            foreach (int area in areas)
            {
                Console.WriteLine(area);
            }
        }

        public static void SelectionSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }

        }

        static void PrintTenShapes(IShapeSeries series)
        {
            series.ResetSeries();

            for (int i = 0; i < 10; i++)
            {
                series.GetNextArea();
                Console.WriteLine(series.CurrentShapeArea);
            }
        }

        public static void SelectionSort2(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }
        }

    }
}
