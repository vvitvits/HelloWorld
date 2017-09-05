namespace Writers
{
    public class ConsoleWriter : ITextWriter
    {
        public string WriteText(string text)
        {
            System.Console.WriteLine(text);
            return text;
        }
    }
}