using System;

namespace Jarai.Patterns.Structural.Facade
{
    public class CdPlayer
    {
        readonly string _description;
        int _currentTrack;
        Amplifier _amplifier;
        string _title;

        public CdPlayer(string description, Amplifier amplifier)
        {
            _description = description;
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine(_description + " on");
        }

        public void Off()
        {
            Console.WriteLine(_description + " off");
        }

        public void Eject()
        {
            _title = null;
            Console.WriteLine(_description + " eject");
        }

        public void Play(string title)
        {
            _title = title;
            _currentTrack = 0;
            Console.WriteLine(_description + " playing \"" + title + "\"");
        }

        public void Play(int track)
        {
            if (_title == null)
            {
                Console.WriteLine(_description + " can't play track " + _currentTrack +
                                   ", no cd inserted");
            }
            else
            {
                _currentTrack = track;
                Console.WriteLine(_description + " playing track " + _currentTrack);
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine(_description + " stopped");
        }

        public void Pause()
        {
            Console.WriteLine(_description + " paused \"" + _title + "\"");
        }

        public override string ToString()
        {
            return _description;
        }
    }
}