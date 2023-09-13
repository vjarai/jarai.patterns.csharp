using System;

namespace Jarai.Patterns.Structural.Bridge
{
    public class InformationForm : Form
    {


        public InformationForm(Layout layout) :
            base(layout)
        {

        }


        public void Show()
        {
            DateTime dateTime = new DateTime();
            DrawTextBox("Current system time: " + dateTime);
        }
    }
}
