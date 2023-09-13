
namespace Jarai.Patterns.Structural.Bridge
{
    public class GreetingForm : Form
    {
        public GreetingForm(Layout screenLayout) :
            base(screenLayout)
        {

        }

        public void Show()
        {
            DrawTextBox("Greetings!");
        }
    }
}

