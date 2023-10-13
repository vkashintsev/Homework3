using Homework3.Interface; 

namespace Homework3.Settings
{
    public class DefaultSettings
    {
        public virtual void SetBorders(IGenerator _generator, int minValue, int maxValue)
        {
            _generator.MinValue = minValue;
            _generator.MaxValue = maxValue;
        }
    }
}
