namespace WeckerApp
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;

    public partial class UI : Form
    {
        private string timeFormat = "HH:mm:ss";

        private bool weckerAktiv = false;

        public event Action<Weckauftrag> WeckerStarten;

        public event Action WeckerStoppen;

        private SynchronizationContext _myContext;

        public UI()
        {
            this.InitializeComponent();
            this._myContext = SynchronizationContext.Current;
            this.zeitwert.Text = DateTime.Now.AddSeconds(15).ToString(this.timeFormat);
        }

        public void UhrzeitAnzeigen(DateTime uhrzeit)
        {
            this._myContext.Send(_ => { this.uhrzeit.Text = uhrzeit.ToString(this.timeFormat); }, null);
        }

        public void RestzeitAnzeigen(TimeSpan restzeit)
        {
            this._myContext.Send(_ => { this.restzeit.Text = restzeit.ToString(); }, null);
        }

        public void OnWeckerGestartet()
        {
            this.weckerAktiv = true;
            this._myContext.Send(_ => { this.buttonStartStop.Text = @"Stop"; }, null);
        }

        public void OnWeckerGestoppt()
        {
            this.weckerAktiv = false;
            this._myContext.Send(_ => { this.buttonStartStop.Text = @"Start"; this.restzeit.Text = string.Empty; }, null);
        }

        private void buttonStartStopClicked(object sender, EventArgs e)
        {
            if (this.weckerAktiv)
            {
                this.WeckerStoppen();
            }
            else
            {
                var weckauftrag = new Weckauftrag(this.zeitwert.Text, 0);
                this.WeckerStarten(weckauftrag);
            }
        }
    }
}
