using System;

namespace StopWatch
{
    public class StopWatch
    {
        private Boolean _isStart;
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _spanInterval;
        public void Start()
        {
            if (_isStart)
            {
                throw new InvalidOperationException();
            }
            _startTime = DateTime.Now;
            _isStart = true;
        }

        public string Stop()
        {
            if (!_isStart)
            {
                throw new InvalidOperationException();
            }

            _stopTime = DateTime.Now;
            _spanInterval = _stopTime - _startTime;
            _isStart = false;
            return _spanInterval.Seconds.ToString();
        }
        
    }
}