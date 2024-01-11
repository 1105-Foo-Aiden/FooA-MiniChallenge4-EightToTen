namespace FooA_MiniChallenge4_EightToTen.Services;

public class NumberGuesserClass : INumberGuesser
{
    public string Easy(int guess)
    {

        if (guess > 10)
        {
            return "Please enter a valid number";
        }
        Random easy = new();
        int winningNumber = easy.Next(1, 11);
        if (guess > winningNumber)
        {
            return "You guessed too high, try again";
        }
        else if (guess < winningNumber)
        {
            return "You guessed too low, try again";
        }
        else if (guess == winningNumber)
        {
            return "You guessed corerctly, congratulations!";
        }

        else
        {
            return "Please enter a number";
        }
    }

    public string Hard(int guess)
    {
        Random hard = new();
        int winningNumber = hard.Next(1, 101);
        if (guess > winningNumber && guess <= 100)
        {
            return "You guessed too high, try again";
        }
        else if (guess < winningNumber)
        {
            return "You guessed too low, try again";
        }
        else if (guess == winningNumber)
        {
            return "You guessed corerctly, congratulations!";
        }
        else if (guess > 100)
        {
            return "Please enter a valid number";
        }
        else
        {
            return "Please enter a number";
        }

    }

    public string Medium(int guess)
    {
        Random medium = new();
        int winningNumber = medium.Next(1, 51);
        if (guess > winningNumber && guess <= 50)
        {
            return "You guessed too high, try again";
        }
        else if (guess < winningNumber)
        {
            return "You guessed too low, try again";
        }
        else if (guess == winningNumber)
        {
            return "You guessed corerctly, congratulations!";
        }
        else if (guess > 50)
        {
            return "Please enter a valid number";
        }
        else
        {
            return "Please enter a number";
        }
    }
}

