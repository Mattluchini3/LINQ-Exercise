namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var GameNames = new List<string>() { "Super Mario", "COD", "Rocket League", "Destiny", };

            GameNames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
        
    }
}


//Create a list of video game names...
//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
//use Method Syntax for this exercise