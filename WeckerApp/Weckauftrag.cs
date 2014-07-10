namespace WeckerApp
{
    using System;

    public class Weckauftrag
    {
        private string zeitwert;

        private int modus;

        public Weckauftrag(string zeitwert, int modus)
        {
            // Prüfung Zeitwert + Modus
            // jetzt z.B. 8:04:00 PM or 18:37:58
            this.zeitwert = zeitwert;
            this.modus = modus;
        }

        internal int AblaufdauerBerechnen()
        {
            var startTime = DateTime.Now;
            var endTime = DateTime.Parse(this.zeitwert);
            var span = endTime.Subtract(startTime);
            var ablaufdauer = Convert.ToInt32(span.Seconds);

            return ablaufdauer;
        }
    }
}
