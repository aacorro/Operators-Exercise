namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Exercise 1

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} reminder {mod}");


            //Exercise 2


            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of a circle wiht radius of {radius} is {AreaOfCircle(radius)}");
            
            AreaOfCircle(radius);


        }
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * (radius * radius);

                
        }
    }
}