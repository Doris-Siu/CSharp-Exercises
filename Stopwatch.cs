using System;
namespace CSharp_stopWatchExercise
{
	public class Stopwatch
	{
		private DateTime _start;
		private DateTime _end;
		private bool _running;

		public void Start()
		{
			if (_running)
			{
				throw new InvalidOperationException("The stopwatch is running already..");
			};

			_start = DateTime.Now;
			_running = true;


		}

		public void Stop()
		{
            if (!_running)
            {
                throw new InvalidOperationException("The stopwatch is not running..");
            };

			_end = DateTime.Now;
			_running = false;
        }

		public TimeSpan GetDuration()
		{
			return _end - _start;
		}

    }
}

