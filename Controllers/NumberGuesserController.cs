using FooA_MiniChallenge4_EightToTen.Services;
using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge4_EightToTen.Controllers;
[ApiController]
[Route("[controller]")]

public class NumberGuesserController : Controller
{
    private readonly INumberGuesser numberGuesser;

    public NumberGuesserController(INumberGuesser numberGuesser)
    {
        this.numberGuesser = numberGuesser;
    }

    [HttpGet]
    [Route("/NumberGuess/Easy/{guess}")]
    public string Easy(int guess){
        return numberGuesser.Easy(guess);
    }

    [HttpGet]
    [Route("/NumberGuess/Medium/{guess}")]
    public string Medium(int guess){
        return numberGuesser.Medium(guess);
    }

    [HttpGet]
    [Route("/NumberGuess/Hard/{guess}")]
    public string Hard(int guess){
        return numberGuesser.Hard(guess);
    }
}
