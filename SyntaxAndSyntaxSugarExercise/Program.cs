namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Inferred Typing

            var answer = 4;
            //var response = answer < 9;


            // String Interpolation

            //Console.WriteLine($" {answer} is less than nine");


            // Ternary operator

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            Console.WriteLine(response);
        }
    }
}
