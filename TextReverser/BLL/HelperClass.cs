namespace TextReverser.BLL
{
    public class HelperClass
    {
        public static string ReversedString(string input)
        {
            return string.Concat(input.ToCharArray().Reverse());
        }
    }
}
