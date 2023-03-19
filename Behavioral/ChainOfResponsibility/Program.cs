using System;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var myAlexa = new Alexa();

            //myAlexa.InstallSkill(new RadioSkill());
            //myAlexa.InstallSkill(new WettervorhersageSkill());
            //myAlexa.InstallSkill(new LampenSkill());
            myAlexa.InstallAllSkills();

            myAlexa.HandleRequest("Schalte Radio HR3 ein");
            myAlexa.HandleRequest("Wetter?");
            myAlexa.HandleRequest("Licht Wohnzimmer");
            myAlexa.HandleRequest("BlaBla");


            Console.ReadLine();
        }
    }
}