using Homework3;
using Homework3.Implementation;
using Homework3.Settings;
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        var generator = new Generator();
        var settings = new ExtendSettings();
        settings.SetBorders(generator, 0, 1000);
        generator.GenerateNumber();
        var validator = new Validator(generator);
        Game game = new Game(generator, validator, settings); 
        game.Start(); 
    }
}