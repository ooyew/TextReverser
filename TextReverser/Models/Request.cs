namespace TextReverser.Models
{
    public class Request
    {
        public Guid Id { get; set; }
        public string Input { get; set; }
        public string ReversedInput { get; set; }
    }
}
