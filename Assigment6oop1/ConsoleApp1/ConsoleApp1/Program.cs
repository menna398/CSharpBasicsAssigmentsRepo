namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            // Problem 1: Struct Point
            // ============================================

            Point p1 = new Point();
            Point p2 = new Point(10, 20);

            Console.WriteLine(p1);
            Console.WriteLine(p2);


            // Problem 2: Access Modifiers
            // ============================================

            TypeA obj = new TypeA();

            // G is internal, so it can be accessed
            // from anywhere inside the same project.
            Console.WriteLine(obj.G);

            // H is public, so it can be accessed
            // from anywhere.
            Console.WriteLine(obj.H);

            // F is private, so it cannot be accessed here.
            // Console.WriteLine(obj.F); // Error


            // Problem 3: Encapsulation
            // ============================================

            Employee employee = new Employee(1, "Menna", 10000);

            Console.WriteLine(employee.GetName());

            employee.SetName("Menna Khaled");

            Console.WriteLine(employee.GetName());

            //Console.WriteLine(employee.Salary);


            // Problem 4: Constructor Overloading
            // ============================================

            Point point1 = new Point(5);
            Point point2 = new Point(10, 20);

            Console.WriteLine(point1);
            Console.WriteLine(point2);


            // Problem 5: Custom ToString()
            // ============================================

            Point point3 = new Point(15, 25);
            Point point4 = new Point(30, 40);

            Console.WriteLine(point3);
            Console.WriteLine(point4);


            // Problem 6: Value Type vs Reference Type
            // ============================================

            Point point = new Point(10, 20);

            Console.WriteLine("Before method:");
            Console.WriteLine(point);

            ChangePoint(point);

            Console.WriteLine("After method:");
            Console.WriteLine(point);


            Employee emp = new Employee(1, "Ahmed", 5000);

            Console.WriteLine("\nBefore method:");
            Console.WriteLine(emp.GetName());

            ChangeEmployee(emp);

            Console.WriteLine("After method:");
            Console.WriteLine(emp.GetName());
        }


        // Struct is passed by value
        static void ChangePoint(Point p)
        {
            p.X = 100;
            p.Y = 200;

            Console.WriteLine("Inside method:");
            Console.WriteLine(p);
        }


        // Class is passed by reference
        static void ChangeEmployee(Employee e)
        {
            e.SetName("Changed Name");

            Console.WriteLine("Inside method:");
            Console.WriteLine(e.GetName());
        }
    }



    // Point Struct
    // ====================================================

    struct Point
    {
        public int X;
        public int Y;

        // Default constructor
        public Point()
        {
            X = 0;
            Y = 0;
        }

        // Constructor with X and Y
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Constructor with X only
        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        // Custom ToString()
        public override string ToString()
        {
            return $"Point: (X = {X}, Y = {Y})";
        }
    }



    // TypeA Class
    // ====================================================

    class TypeA
    {
        private int F = 10;
        internal int G = 20;
        public int H = 30;

        public void DisplayF()
        {
            Console.WriteLine(F);
        }
    }



    // Employee Struct
    // ====================================================

    struct Employee
    {
        private int EmpId;
        private string Name;
        private double Salary;

        public Employee(int empId, string name, double salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }

        // GetName method
        public string GetName()
        {
            return Name;
        }

        // SetName method
        public void SetName(string name)
        {
            Name = name;
        }

        // Properties
        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        public string EmployeeName
        {
            get { return Name; }
            set { Name = value; }
        }

        public double EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }
    }
