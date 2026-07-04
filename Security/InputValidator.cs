public class InputValidator
{
    public bool IsValid(string input)
    {
        return !string.IsNullOrWhiteSpace(input);
    }
}
