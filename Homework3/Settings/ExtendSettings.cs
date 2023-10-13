using Homework3.Interface; 

namespace Homework3.Settings
{
    public class ExtendSettings : DefaultSettings
    {
        public override void GenerateNumber(IGenerator _generator)
        {
            _generator.GenerateNumber(0, 10000);
        }
    }
}
