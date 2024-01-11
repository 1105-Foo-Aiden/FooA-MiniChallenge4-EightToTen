namespace FooA_MiniChallenge4_EightToTen.Services.Magic8Ball;

public class EightBall : IEightBall
{
     public string eightBall(string question)
    {
    
        Random rnd = new Random();
        int randomNumber = rnd.Next(8);

        switch(randomNumber){
            case 0:
            return "It is certain";
            case 1:
            return "It is decidedly so";

            case 2:
            return "Reply hazy try again";

            case 3:
            return "Cannot predit now";

            case 4:
            return "Do not count on it";

            case 5:
            return "My sources say no'";

            case 6:
            return "Outlook is not goo";

            case 7:
            return "Signs point to yes";

            case 8:
            return "Definitely not";
            default:
            return "Ask the magic 8 Ball a question and it shall give an answer";
        }
    }    
}
