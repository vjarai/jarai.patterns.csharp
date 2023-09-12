using System;


public class Program {

    public static void Main(string[] args) {

        var windowsLayout = new DesktopLayout();
        var tabletLayout = new MobileLayout();

        var greetingForm1 = new GreetingForm(windowsLayout);
        var greetingForm2 = new GreetingForm(tabletLayout);

        var informationForm1 = new InformationForm(windowsLayout);
        var informationForm2 = new InformationForm(tabletLayout);

        Console.WriteLine("Starting test:\n");

        greetingForm1.DrawText("\nScreen 1 (Refined Abstraction 1, Implementation 1):");
        greetingForm1.Show();

        greetingForm2.DrawText("\nScreen 2 (Refined Abstraction 1, Implementation 2):");
        greetingForm2.Show();

        informationForm1.DrawText("\nScreen 3 (Refined Abstraction 2, Implementation 1):");
        informationForm1.Show();

        informationForm2.DrawText("\nScreen 4 (Refined Abstraction 2, Implementation 2):");
        informationForm2.Show();
    }
}