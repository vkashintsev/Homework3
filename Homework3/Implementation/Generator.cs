using Homework3.Interface;

namespace Homework3.Implementation
{
    public class Generator : IGenerator
    {
        public int MinValue {  get; set; }
        public int MaxValue { get; set; }

        private Random Rand = new Random();
        public int Number { get; set; }
        public Generator() {
            MinValue = 0;
            MaxValue = 100;
            Number = 0;
        }
        public void GenerateNumber()
        {
            Number = Rand.Next(MinValue, MaxValue);
        }
    }
}
