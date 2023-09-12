
using System;

public class DesktopLayout : Layout {


    public override void PrintLine() {
        Console.WriteLine();
    }


    public override void PrintDecor() {
        Console.Write("*");
    }


    public override void PrintText(string text) {
        Console.WriteLine(text);
    }
}
