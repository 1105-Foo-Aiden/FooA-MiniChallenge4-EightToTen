namespace FooA_MiniChallenge4_EightToTen.Services;

public interface INumberGuesser
{
    public string Easy(int guess);
    public string Medium(int guess);
    public string Hard(int guess);
}
