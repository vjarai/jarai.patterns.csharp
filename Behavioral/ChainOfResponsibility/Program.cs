using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarai.Patterns.Behavioral.ChainOfResponsibilty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myAlexa = new Alexa();
            myAlexa.AddSkill(new RadioSkill());
            myAlexa.AddSkill(new WettervorhersageSkill());
            myAlexa.AddSkill(new LampenSkill());

            myAlexa.HandleRequest("Schalte Radio HR3 ein");
            myAlexa.HandleRequest("Wetter?");
            myAlexa.HandleRequest("Licht Wohnzimmer");
            myAlexa.HandleRequest("BlaBla");


            Console.ReadLine();

        }
    }
}
