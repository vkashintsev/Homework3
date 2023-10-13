using Homework3.Interface; 

namespace Homework3.Settings
{
    public class ExtendSettings : DefaultSettings
    {
        public override void SetBorders(IGenerator _generator, int minValue, int maxValue)
        {
            _generator.MinValue = minValue * 2;
            _generator.MaxValue = maxValue * 2;
        }
    }
}
