using lesson_8;

namespace lesson_8
{
    public class Program
    {
        public void Main()
        {
            string filename = Console.ReadLine();
            if (FileParser.GetParser(filename) != null)
            {
                FileParser.GetParser(filename).Parse();
            }
            else Console.WriteLine("Ошибка");
        }

    }
}