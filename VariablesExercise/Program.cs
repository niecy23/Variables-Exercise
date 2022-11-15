namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, Fellow Basketball Player! What is your name?");
            string PlayerName = Console.ReadLine();

            Console.WriteLine($"What position do you play (ex. 1,2,3,4, or 5)?");
            char PlayerPosition = Convert.ToChar(Console.ReadLine());
           
            Console.WriteLine($"How old are you?");
            int PlayerAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Have you graduated from High School? (True or False)");
            bool GraduationStatus = Convert.ToBoolean(Console.ReadLine());

            if (GraduationStatus)
            {
                Console.WriteLine($"Congratulations!");
            }

            Console.WriteLine($"What is your GPA?");
            double PlayerGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"What is your shoe size?");
            decimal PlayerShoeSize = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"Hello! Based on the information that you provided, your name is {PlayerName}, and you play the {PlayerPosition} position. You are {PlayerAge} years old, and you have a GPA of {PlayerGPA}. Lastly, you wear a size {PlayerShoeSize} shoe. Thank you for providing this information!");

        }
    }
}
