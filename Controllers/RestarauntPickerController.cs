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
    [Route("/RestaurantPicker/FastFoodSitDownTakeOut/{typeOfRestaurant}")]
    public string RestarauntPicker(string typeOfRestaurant){
        return picker.RestarauntPicker(typeOfRestaurant);
    }
}
