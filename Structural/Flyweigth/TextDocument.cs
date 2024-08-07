using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Structural.Flyweigth
{
    public class TextDocument
    {
        private readonly List<FlyweightText> _text = new List<FlyweightText>();

        readonly FormatCache _formatCache = new FormatCache();

        public void AddText(string text, string fontName = "Arial", int fontSize = 10, bool isBold = false, bool isUnderline = false, bool isItalic = false)
        {
            var format = _formatCache.GetOrCreateFormat(fontName, fontSize, isBold, isUnderline, isItalic);

            _text.Add(new FlyweightText { Text = text, Format = format });
        }

        public void Show()
        {
            foreach (var formattedText in _text)
            {
                Console.WriteLine(formattedText);
            }
        }
    }
}