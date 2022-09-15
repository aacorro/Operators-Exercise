namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b; 

            Console.WriteLine($"{a}/{b} is {div} reminder {mod}");
        }
    }
}