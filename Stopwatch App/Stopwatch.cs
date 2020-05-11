using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Stopwatch_App
{
    public class Stopwatch
    {
        private bool _isRunning = false;
        private DateTime _startTime;
        private DateTime _endTime;

        private TimeSpan duration
        {
            get
            {
                return _endTime - _startTime;
            }
        }

        public void Start ()
        {
            if (_isRunning)
                throw new InvalidOperationException("Cannot call the start method consecutively");

            this._startTime = DateTime.Now;
            Console.WriteLine("start time: " + this._startTime);

            _isRunning = true;
        }

        public void Stop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Cannot call the stop method consecutively");

            this._endTime = DateTime.Now;
            Console.WriteLine("end time: " + _endTime);
            Console.WriteLine("duration: " + duration.TotalSeconds);
            _isRunning = false;
        }
    }
}
