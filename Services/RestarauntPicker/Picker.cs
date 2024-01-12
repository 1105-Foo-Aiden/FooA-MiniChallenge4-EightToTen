namespace FooA_MiniChallenge4_EightToTen.Services.RestarauntPicker;

public class Picker : IPicker
{
   
    public string SitDown(string sitdown)
    {
        string[] stringArray = { "Dave Wongs", "Raw Sushi & bristo", "Papapavlo's", "Waterloo club", "Angelina's", "Market Tavern", "Senior Frogs", "Strings", "Red Robin", "Moo Moo's" };
        string sitDownPick = stringArray[new Random().Next(0, stringArray.Length)];
        return $"The conch has spoken, you will go to {sitDownPick}";
    }
    
    public string TakeOut(string takeout)
    {
        string[] stringArray = { "Little Ceasers", "Bj's", "David's Pizza", "Domino's Pizza", "Eddie's Pizza", "Dante's Pizza", "Panda Express", "Chipotle", "Wing Stop", "Pizza Hut" };
        string delivPick = stringArray[new Random().Next(0, stringArray.Length)];
        return $"Your restaurant is {delivPick}";
    }
    
    public string FastFood(string typeOfRestaurant)
    {
        string[] stringArray = { "McDonalds", "Taco Bell", "Wendey's", "El Pollo Loco", "In'N Out", "Burger King", "AMW", "Sonic", "Jack In the Box", "Carl's Jr." };
        string fastFoodPick = stringArray[new Random().Next(0, stringArray.Length)];
        return $"The wheel has chosen {fastFoodPick}";
    }

    public string RestarauntPicker(string typeOfRestaurant)
    {
        if(typeOfRestaurant.ToLower() == "fastfood"){
            return FastFood(typeOfRestaurant);
        }
        else if(typeOfRestaurant.ToLower() == "sitdown"){
            return SitDown(typeOfRestaurant);
        }
        else if(typeOfRestaurant.ToLower() == "takeout"){
            return TakeOut(typeOfRestaurant);
        }
        else{
            return "Please enter \"fastfood\", \"sitdown\" or \"takeout\"";
        }
    }
}
