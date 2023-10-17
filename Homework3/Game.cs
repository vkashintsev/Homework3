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
        public Game(IGenerator generator, IValidator validator, DefaultSettings settings)
        {
            if (generator == null || generator.Number == 0)
            {
                _generator = new Generator();
                _generator.GenerateNumber();
            }
            else
                _generator = generator;
            if (settings == null)
            {
                _settings = new ExtendSettings();
                _settings.SetBorders(_generator, 0, 1000);
            }
            else
                _settings = settings;
            _check = (validator == null) ? new Validator(_generator) : validator;

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
