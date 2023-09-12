
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

