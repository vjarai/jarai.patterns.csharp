
using System;

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
