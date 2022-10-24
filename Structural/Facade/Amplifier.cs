

using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class Amplifier
    {
        readonly String _description;
        Tuner _tuner;
        DvdPlayer _dvd;
        CdPlayer _cd;

        public Amplifier(String description)
        {
            _description = description;
        }

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine(_description + " stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine(_description + " surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine(_description + " setting volume to " + level);
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine(_description + " setting tuner to " + _dvd);
            _tuner = tuner;
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine(_description + " setting DVD player to " + dvd);
            _dvd = dvd;
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine(_description + " setting CD player to " + cd);
            _cd = cd;
        }

        public override String ToString()
        {
            return _description;
        }
    }
}