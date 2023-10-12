namespace Homework3.Interface
{
    public interface IGenerator
    {
        public void GenerateNumber(int begin, int end);
        public int Number { get; set; }
    }
}
