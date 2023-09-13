namespace Jarai.Patterns.Structural.Bridge
{
    public abstract class Form {

        private  Layout _layout;


        public Form(Layout layout) {
            _layout = layout;
        }


        public void DrawText(string text) {
            _layout.PrintText(text);
            _layout.PrintLine();
        }


        public void DrawTextBox(string text) {

            int length = text.Length;

            for (int i = 0; i < length + 4; i++) {
                _layout.PrintDecor();
            }

            _layout.PrintLine();
            _layout.PrintDecor();
            _layout.PrintText(" " + text + " ");
            _layout.PrintDecor();
            _layout.PrintLine();

            for (int i = 0; i < length + 4; i++) {
                _layout.PrintDecor();
            }

            _layout.PrintLine();
        }
    }
}
        