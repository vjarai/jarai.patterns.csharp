using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Structural.Flyweigth
{
    public class FormatFactory
    {
        readonly Dictionary<string, Format> _cache = new Dictionary<string, Format>();

        public Format CreateOrGetFormat(string fontName, int fontSize, bool isBold, bool isUnderline, bool isItalic)
        {
            string key = GetKey(fontName, fontSize, isBold, isUnderline, isItalic);

            if (!_cache.ContainsKey(key))
            {
                _cache[key] = new Format{FontName = fontName, FontSize = fontSize, IsBold = isBold, IsUnderline = isUnderline, IsItalic = isItalic};
            }

            return _cache[key];
        }

        private static string GetKey(string fontName, int fontSize, bool isBold, bool isUnderline, bool isItalic)
        {
            return $"{fontName} {fontSize}, IsBold:{isBold}, IsUnderline{isUnderline}, IsItalic{isItalic}";
        }
    }
}