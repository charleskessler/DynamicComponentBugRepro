using Shared;
using TestWizard.Screens;

namespace TestWizard
{
    public class MyTestWizard : IWizard
    {
        public WizardProperties Properties { get; init; }

        public MyTestWizard()
        {
            Properties = new WizardProperties();
            Properties.ScreenTypes.Add(typeof(DemoScreen));
        }
    }
}
