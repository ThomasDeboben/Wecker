namespace WeckerApp
{
    using System;
    using System.Timers;

    class TimerProvider
    {
        private Timer countdownTimer = new Timer(1000);

        private Timer uhrzeitTimer = new Timer(1000);

        private int countdown;

        public event Action<TimeSpan> Restzeit;

        public event Action<DateTime> Uhrzeit;

        public event Action CountdownGestartet; 

        public event Action CountdownGestoppt; 

        public TimerProvider()
        {
            this.uhrzeitTimer.Elapsed += (sender, elapsedEventArgs) => this.Uhrzeit(DateTime.Now);
            this.countdownTimer.Elapsed += this.OnTimerElapsed;
        }

        public void UhrStarten()
        {
            this.uhrzeitTimer.Start();
        }

        public void CountdownStoppen()
        {
            this.countdownTimer.Stop();
            this.CountdownGestoppt();
        }

        public void CountdownStarten(int ablaufdauer)
        {
            this.countdown = ablaufdauer;
            this.countdownTimer.Enabled = true; // Enable it
            this.CountdownGestartet();
        }

        void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            this.countdown--;
            this.Restzeit(TimeSpan.FromSeconds(this.countdown));

            if (this.countdown <= 0)
            {
                this.countdownTimer.Stop();
                this.CountdownGestoppt();
            }
        }
    }
}
