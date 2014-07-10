namespace WeckerApp
{
    using System;

    class EntryPoints // NUR INTEGRATION
    {
        TimerProvider timerProvider;

        public event Action<TimeSpan> RestzeitUpdated;

        public event Action WeckerAbgelaufen;

        public EntryPoints(TimerProvider timerProvider)
        {
            this.timerProvider = timerProvider;
            this.timerProvider.Restzeit += (restzeit) =>
            {
                this.RestzeitUpdated(restzeit);
                this.PruefeWeckerAbgelaufen(restzeit,
                    this.WeckerAbgelaufen);
            };
        }

        public void WeckerStarten(Weckauftrag auftrag)
        {
            var ablaufdauer = auftrag.AblaufdauerBerechnen();
            this.timerProvider.CountdownStarten(ablaufdauer);
        }

        public void WeckerStoppen()
        {
            this.timerProvider.CountdownStoppen();
        }

        private void PruefeWeckerAbgelaufen(TimeSpan restzeit, Action beiAbgelaufen)
        {
            if (restzeit.TotalSeconds <= 0)
            {
                beiAbgelaufen();
            }
        }
    }
}
