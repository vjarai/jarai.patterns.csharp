using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jarai.Patterns.Structural.Flyweigth
{
    public class Format
    {

        public string FontName
        {
            get;
            set;
        }

        public int FontSize
        {
            get;
            set;
        }

        public bool IsBold
        {
            get;
            set;
        }

        public bool IsItalic { get; set; }

        public bool IsUnderline { get; set; }

        public override string ToString()
        {
            return $"[{FontName}{FontSize}{(IsBold?" ,Bold" : "")}{(IsUnderline?" ,Underline" : "")}{(IsItalic?" ,Italic":"")}]";
        }
    }
}