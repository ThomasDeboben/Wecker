namespace WeckerApp
{
    class App     // NUR INTEGRATION
    {
        public UI ui = new UI();
        public static TimerProvider timerProvider = new TimerProvider();
        private EntryPoints entryPoints = new EntryPoints(timerProvider);
        private Sound sound = new Sound();

        public App()
        {
            timerProvider.Uhrzeit += this.ui.UhrzeitAnzeigen;
            this.ui.WeckerStarten += this.entryPoints.WeckerStarten;
            this.ui.WeckerStoppen += this.entryPoints.WeckerStoppen;
            timerProvider.CountdownGestartet += this.ui.OnWeckerGestartet;
            timerProvider.CountdownGestoppt += this.ui.OnWeckerGestoppt;
            this.entryPoints.RestzeitUpdated += this.ui.RestzeitAnzeigen;
            this.entryPoints.WeckerAbgelaufen += this.sound.Play;

            timerProvider.UhrStarten();
        }
    }
}
