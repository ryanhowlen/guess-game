namespace Number_Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int num = r.Next(1, 100);
            int guesses = 5;

            bool win = false;

            do
            {
                try
                {
                    Console.WriteLine("Enter Guess:");
                    int guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == num)
                    {
                        Console.WriteLine("You Got It!!");
                        win = true;
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Higher than that");
                        guesses--;
                        Console.WriteLine($"You have {guesses} guesses left");
                        
                    }
                    else
                    {
                        Console.WriteLine("Lower than that");
                        guesses--;
                        Console.WriteLine($"You have {guesses} guesses left");
                    }
                }
                catch
                {
                    Console.WriteLine("Guess must be a number");
                }

            } while (win == false && guesses > 0);
        }
    }
}