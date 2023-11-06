namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            int a = 17;
            int b = 4;
            
            var sum = a + b;
            var multiply = a * b;
            var subtract = a - b;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}.");


            //Exercise 2
            Console.WriteLine("What is the radius of the circle?");

            var radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle( radius );
            Console.WriteLine($"The Area of the circle is {area}.");

        }
        public static double AreaOfCircle(double radius)
        {
            double area;
            area = (Math.PI * radius * radius);
            return area;   
        }

    }
}
