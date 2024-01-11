using FooA_MiniChallenge4_EightToTen.Services.RestarauntPicker;
using Microsoft.AspNetCore.Mvc;

namespace FooA_MiniChallenge4_EightToTen.Controllers;
[ApiController]
[Route("[controller]")]
public class RestarauntPickerController : Controller
{
    private readonly IPicker picker;

    public RestarauntPickerController(IPicker picker)
    {
        this.picker = picker;
    }
    [HttpGet]
    [Route("/RestarauntPicker/FF/{fastfood}")]
    
    public string FastFood(string fastfood)
    {
        return picker.FastFood(fastfood);
    }

    [HttpGet]
    [Route("/RestarauntPicker/SD/{sitdown}")]
    public string SitDown(string sitdown)
    {
        return picker.SitDown(sitdown);
    }
    [HttpGet]
    [Route("/RestarauntPicker/TO/{takeout}")]

    public string TakeOut(string takeout)
    {
        return picker.TakeOut(takeout);

    }
}
