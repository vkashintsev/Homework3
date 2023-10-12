using Homework3.Interface;

namespace Homework3.Implementation
{
    public class Generator : IGenerator
    {
        
        private Random Rand = new Random();
        public int Number { get; set; }
        public void GenerateNumber(int begin, int end)
        {
            Number = Rand.Next(begin, end);
        }
    }
}
