namespace Homework3.Interface
{
    public interface IGenerator
    {
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public void GenerateNumber();
        public int Number { get; set; }
    }
}
