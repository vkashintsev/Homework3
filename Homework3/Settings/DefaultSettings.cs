using Homework3.Interface; 

namespace Homework3.Settings
{
    public class DefaultSettings
    {
        public virtual void GenerateNumber(IGenerator _generator)
        {
            _generator.GenerateNumber(0, 1000);
        }
    }
}
