using Homework3.Interface; 

namespace Homework3.Implementation
{
    public class Validator : IValidator
    {
        private IGenerator _generator;
        public Validator(IGenerator generator)
        {
            _generator = generator;
        }
        public int Check(int number)
        {
            if (_generator.Number > number)
                return 1;
            if (_generator.Number < number)
                return -1;
            return 0;
        }
    }
}
