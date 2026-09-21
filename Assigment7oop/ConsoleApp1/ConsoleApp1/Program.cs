namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //q1

            Car car1 = new Car();
            Car car2 = new Car(1);
            Car car3 = new Car(2, "BMW");
            Car car4 = new Car(3, "Toyota", 500000);

            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);
            Console.WriteLine(car4);


            //q2

            Calculator calculator = new Calculator();

            Console.WriteLine(calculator.Sum(10, 20));
            Console.WriteLine(calculator.Sum(10, 20, 30));
            Console.WriteLine(calculator.Sum(10.5, 20.5));


            //q3

            Child child = new Child(10, 20, 30);

            Console.WriteLine(child.X);
            Console.WriteLine(child.Y);
            Console.WriteLine(child.Z);


            //q4

            Child child1 = new Child(5, 10, 20);

            Parent parentReference = child1;

            Console.WriteLine(child1.Product());
            Console.WriteLine(parentReference.Product());

            Console.WriteLine(child1.ProductOverride());
            Console.WriteLine(parentReference.ProductOverride());


            //q5

            Parent parent = new Parent(10, 20);
            Child child2 = new Child(10, 20, 30);

            Console.WriteLine(parent.ToString());
            Console.WriteLine(child2.ToString());

            Parent parentReference2 = child2;

            Console.WriteLine(parentReference2.ToString());


        }
    }

   
}

