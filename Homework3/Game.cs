using Homework3.Implementation;
using Homework3.Interface;
using Homework3.Settings;

namespace Homework3
{
    public class Game
    {
        private IGenerator _generator;
        private IValidator _check;
        private int _count;
        private DefaultSettings _settings;
        public Game()
        {
            _generator = new Generator();
            _settings = new ExtendSettings();
            _settings.SetBorders(_generator, 0, 1000);
            _generator.GenerateNumber();
            _check = new Validator(_generator);

        } 
        public void Start()
        {
            _count = 0;
            while (true)
            {
                Console.WriteLine("Ввод числа");
                var number = Convert.ToInt32(Console.ReadLine());
                _count++;
                switch (_check.Check(number))
                {
                    case 1:
                        Console.WriteLine("Число больше загаданного");
                        break;
                    case -1:
                        Console.WriteLine("Число меньше загаданного");
                        break;
                    default:
                        Console.WriteLine($"Число угадано. Число попыток: {_count}. Число {number}");
                        return;
                }
            }
        }
    }
}
