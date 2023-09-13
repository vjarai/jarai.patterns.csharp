
using System;

namespace Jarai.Patterns.Structural.Bridge
{
    public class MobileLayout : Layout {


        public override void PrintLine() {
            Console.WriteLine();
        }


        public override void PrintDecor() {
            Console.Write("X");
        }


        public override void PrintText(string text) {
            Console.WriteLine(text.ToUpper());
        }
    }
}
