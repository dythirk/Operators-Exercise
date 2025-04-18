namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);

        }
        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;

            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}.");
            Console.WriteLine($"{a} - {b} is {difference}.");
            Console.WriteLine($"{a} * {b} is {product}.");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}.\n");


            Console.WriteLine("Please enter the radius:");
            double radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);

            Console.WriteLine($"\nThe area of a circle with radius {radius} is :{area}.");


        }


    }
}
