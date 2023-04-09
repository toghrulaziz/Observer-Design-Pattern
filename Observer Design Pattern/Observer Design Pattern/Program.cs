namespace Observer_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewsSite newsSite = new NewsSite();

            NewsReader reader1 = new NewsReader("Reader 1", newsSite);
            NewsReader reader2 = new NewsReader("Reader 2", newsSite);

            newsSite.RegisterObserver(reader1);
            newsSite.RegisterObserver(reader2);

            newsSite.PublishNews("COVID-19 vaccine found!");

            Console.WriteLine();

            newsSite.RemoveObserver(reader2);

            newsSite.PublishNews("New iPhone model introduced!");

            Console.ReadKey();
        }
    }
}