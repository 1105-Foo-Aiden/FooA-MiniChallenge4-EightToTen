using FooA_MiniChallenge4_EightToTen.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;


namespace FooA_MiniChallenge4_EightToTen.Controllers;
[ApiController]
[Route("[conroller]")]
public class Magic8BallController : Controller
{
    private readonly IEightBall eightBall;

    public Magic8BallController(IEightBall eightBall)
    {
        this.eightBall = eightBall;
    }
    [HttpGet]
    [Route("/8Ball/{question}")]
    public string EightBall(string question)
    {
        return eightBall.eightBall(question);
    }    
}
